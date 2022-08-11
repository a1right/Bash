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
            if (IsContainsLogicalOperator(node, out string logicalOperator) && node.Command.Expression.Length > logicalOperator.Length)
            {
                var indexOfOperator = node.Command.Expression.IndexOf(logicalOperator);
                var left = node.Command.Expression.Substring(0, indexOfOperator).Trim();
                var right = node.Command.Expression.Substring(indexOfOperator + logicalOperator.Length).Trim();
                node.Command = new Command(logicalOperator);
                node.SetLeft(new Node(left));
                node.SetRight(new Node(right));
                Console.WriteLine($"Current node: {node.Command.Expression}");
                Console.WriteLine($"Parsing left: {node.Left.Command.Expression}     /     Parsing right: {node.Right.Command.Expression}");
                FillTree(node.Left);
                FillTree(node.Right);
            }
            if (IsContainsExecuteOperator(node, out string executeOperator))
            {
                Console.WriteLine("Entered else statement: executeOperator");
                var indexOfOperator = node.Command.Expression.IndexOf(executeOperator);
                //var left = node.Command.Expression.Substring(0, indexOfOperator).Trim();
                var left = node.Command.Expression.Substring(indexOfOperator + executeOperator.Length).Trim();
                node.Command = new Command(executeOperator);
                node.SetLeft(new Node(left));
                //node.SetRight(new Node(right));
                Console.WriteLine($"Current operator: {node.Command.Expression}");
                Console.WriteLine($"{node.Command.Expression} args: {node.Left.Command.Expression}");
            }

            Console.WriteLine("end");
        }
        private bool IsContainsLogicalOperator(Node node, out string logicalOperator)
        {
            foreach (var op in LogicalOperators.GetOperatorsList())
            {
                if (node.Command.Expression.Contains(op))
                {
                    logicalOperator = op;
                    node.MarkAsLogicalOperator();
                    return true;
                }
            }
            logicalOperator = string.Empty;
            return false;
        }
        private bool IsContainsExecuteOperator(Node node, out string executeOperator)
        {
            foreach (var op in ExecuteOperators.GetOperatorsList())
            {
                if (node.Command.Expression.Contains(op))
                {
                    executeOperator = op;
                    node.MarkAsExecuteOperator();
                    return true;
                }
            }
            executeOperator = string.Empty;
            return false;
        }
    }
}
