using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public class AST
    {
        public Command Input { get; private set; }
        public Node Root { get; set; }
        public AST(Command command)
        {
            var node = new Node(command);
            Root = node;
        }
        public AST(Node root)
        {
            Root = root;
            Root.Previous = null;
        }
        
        public AST Split()
        {
            FillTree(Root);
            Console.WriteLine("Parse finished");
            return this;
        }
        private void FillTree(Node node)
        {
            if (IsCommandContainsLogicalOperations(node, out string unionOperator) && node.Command.Expression.Length > unionOperator.Length)
            {
                var indexOfOperator = node.Command.Expression.IndexOf(unionOperator);
                var left = node.Command.Expression.Substring(0, indexOfOperator).Trim();
                var right = node.Command.Expression.Substring(indexOfOperator + unionOperator.Length).Trim();
                //Console.WriteLine($"Current node: {node.Command.Expression}");
                //Console.WriteLine($"Parsing left: {left} / Parsing right: {right}");
                
                node.Command = new Command(unionOperator);
                node.SetLeft(new Node(left));
                node.SetRight(new Node(right));
                Console.WriteLine($"Current node: {node.Command.Expression}");
                Console.WriteLine($"Parsing left: {node.Left.Command.Expression}     /     Parsing right: {node.Right.Command.Expression}");
                FillTree(node.Left);
                FillTree(node.Right);
            }
            else
            {

            }
            Console.WriteLine("end");
        }
        private bool IsCommandContainsLogicalOperations(Node node, out string logicalOperator)
        {
            Type unionOperators = typeof(LogicalOperator);
            FieldInfo[] operators = unionOperators.GetFields(BindingFlags.Static | BindingFlags.Public);
            foreach(var oper in operators)
            {
                logicalOperator = oper.GetValue(null).ToString();
                if (node.Command.Expression.Contains(logicalOperator))
                {
                    node.MarkAsLogicalOperator();
                    return true;
                }
            }
            logicalOperator = string.Empty;
            return false;
        }
    }
}
