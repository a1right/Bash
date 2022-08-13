using Bash.Operators.BooleanOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.ExecuteOperators
{
    public class PrintWorkingDirectory : IExecuteOperator
    {
        public bool IsRequireArgs { get; } = false;

        public OperatorType OperatorType { get; } = OperatorType.Execute;

        public string OperatorKey { get; } = "pwd";
        public bool ReturnStatus { get; private set; }

        public void Execute(params string[] args)
        {
            Console.WriteLine(GlobalVariables.CurrentDirectory);
            var directories = Directory.GetDirectories(GlobalVariables.CurrentDirectory);
            foreach(var item in directories)
            {
                Console.WriteLine(item.Replace(GlobalVariables.CurrentDirectory, "") + "\r\t\t\t\t\t--Folder");
            }
            var files = Directory.GetFiles(GlobalVariables.CurrentDirectory);
            foreach(var item in files)
            {
                var fileName = item.Replace(GlobalVariables.CurrentDirectory + "\\", "");
                var fileExtension = fileName.Substring(fileName.IndexOf(".") + 1);
                Console.WriteLine((fileName) + $"\r\t\t\t\t\t--{fileExtension} File");
            }
            ReturnStatus = true;
        }
    }
}
