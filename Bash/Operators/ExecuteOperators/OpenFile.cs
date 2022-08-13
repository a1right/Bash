using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.ExecuteOperators
{
    public class OpenFile : IExecuteOperator
    {
        public bool IsRequireArgs { get; } = true;

        public OperatorType OperatorType { get; } = OperatorType.Execute;

        public string OperatorKey { get; } = "cat";

        public bool ReturnStatus { get; private set; }

        public void Execute(params string[] args)
        {

            if (args.Length == 1 && File.Exists(args[0]))
            {
                var path = args[0];
                if (path.StartsWith(".\\") || path.StartsWith("./"))
                {
                    path = GlobalVariables.CurrentDirectory + path;
                }
                var text = File.ReadAllText(path);
                Console.WriteLine(text);
                Console.WriteLine("-------END FILE-------");
                ReturnStatus = true;
            }
            else
            {
                ReturnStatus = false;
                Console.WriteLine("File does not exist");
            }
        }
    }
}
