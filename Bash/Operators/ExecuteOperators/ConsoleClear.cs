using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.ExecuteOperators
{
    public class ConsoleClear : IExecuteOperator
    {
        public bool IsRequireArgs { get; } = false;

        public OperatorType OperatorType { get; } = OperatorType.Execute;

        public string OperatorKey { get; } = "cls";

        public bool ReturnStatus { get; private set; }

        public void Execute(params string[] args)
        {
            Console.Clear();
            ReturnStatus = true;
        }
    }
}
