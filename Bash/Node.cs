using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public class Node
    {
        public Command Command { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Previous { get; set; }
        public bool IsLogicalOperator { get; private set; }
        public bool IsExecuteOperator { get; private set; }
        public bool IsArgument { get; private set; }
        public void MarkAsLogicalOperator()
        {
            IsLogicalOperator = true;
        }
        public void MarkAsExecuteOperator()
        {
            IsExecuteOperator = true;
        }
        public void MarkAsArgument()
        {
            IsArgument = true;
        }

        public Node(string expression)
        {
            Command = new Command(expression);
        }
        public Node(Command command)
        {
            Command = command;
            Left = null;
            Right = null;
        }
        public void SetRight(Node node)
        {
            node.Previous = this;
            Right = node;
        }
        public void SetLeft(Node node)
        {
            node.Previous = this;
            Left = node;
        }
        public override string ToString()
        {
            if (Command != null)
                return Command.Expression.ToString();
            return string.Empty;
        }
    }
}
