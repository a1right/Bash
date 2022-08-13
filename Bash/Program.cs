using Bash.Operators;
using Bash.Operators.ExecuteOperators;
using System.Reflection;

namespace Bash
{
    public class Base
    {
        public int A { get; set; }
        public string Name { get; set; } = "Базовый";
        
    }
    public class Extend : Base
    {
        public string Description { get; set; }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                var split = input.Split(" ");
                var operation = split[0];
                var argument = string.Empty;
                if(split.Length > 1)
                    argument = split[1];
                if (operation == "cd")
                {
                    var cd = new ChangeDirectory();
                    cd.Execute(argument);
                }
                if (operation == "pwd")
                {
                    var pwd = new PrintWorkingDirectory();
                    pwd.Execute();
                }
            }
        }
    }
}