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

        public void Execute(string args)
        {
            if (args.StartsWith(".\\") || args.StartsWith("./"))
            {
                args = Settings.CurrentDirectory + args;
            }
            if (Directory.Exists(args))
            {
                Settings.CurrentDirectory = args;
                var pwd = new PrintWorkingDirectory();
                pwd.Execute();
                return;
            }
            else
            {
                Console.WriteLine("Directory isnt exists");
            }
        }
    }
}
