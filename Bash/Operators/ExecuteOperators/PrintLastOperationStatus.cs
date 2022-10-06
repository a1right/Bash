using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.ExecuteOperators
{
    public class PrintLastOperationStatus : IExecuteOperator
    {
        public bool IsRequireArgs { get; } = false;

        public OperatorType OperatorType { get; } = OperatorType.Execute;

        public string OperatorKey { get; } = "$?";

        public bool ReturnStatus { get; private set; }

        public void Execute(params string[] args)
        {
            if(GlobalVariables.LastOperatorReturnedStatus != null)
            {
                var status = OperatorsFactory.GetOperatorIfExists(GlobalVariables.LastOperatorReturnedStatus.ToString(), out IOperator op);
                Console.WriteLine($"Last operator: {GlobalVariables.LastOperatorReturnedName} returned status {op}({op.OperatorKey})");
                return;
            }
            else
            {
                Console.WriteLine("No operations executed yet");
            }
        }
    }
}
