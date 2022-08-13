using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.ExecuteOperators
{
    public class ChangeDirectory : IExecuteOperator
    {
        public bool IsRequireArgs { get; } = true;

        public OperatorType OperatorType { get; } = OperatorType.Execute;

        public string OperatorKey { get; } = "cd";
        public bool ReturnStatus { get; private set; }

        public void Execute(params string[] args)
        {
            if (args.Length == 1)
            {
                var arguments = args[0];
                if (arguments.StartsWith(".\\") || arguments.StartsWith("./"))
                {
                    arguments = GlobalVariables.CurrentDirectory + arguments;
                }
                if (Directory.Exists(arguments))
                {
                    GlobalVariables.CurrentDirectory = arguments;
                    ReturnStatus = true;
                    return;
                }
                else
                {
                    ReturnStatus = false;
                    Console.WriteLine("Directory doesn`t exists");
                    return;
                }
            }
            ReturnStatus = false;
            Console.WriteLine($"{OperatorKey}: incorrect argument");
        }
    }
}
