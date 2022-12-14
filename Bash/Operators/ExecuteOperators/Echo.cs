using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.ExecuteOperators
{
    public class Echo : IExecuteOperator
    {
        public bool IsRequireArgs { get; } = true;

        public OperatorType OperatorType { get; } = OperatorType.Execute;

        public string OperatorKey { get; } = "echo";
        public bool ReturnStatus { get; private set; }
        public void Execute(params string[] args)
        {
            foreach(var word in args)
            {
                Console.Write(word);
            }
        }
    }
}
