using Bash.Operators;
using Bash.Operators.ExecuteOperators;

namespace Bash
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                var lexer = new Lexer();
                var data = lexer.GetCommandList();
                var interpreter = new Interpreter(data);
                interpreter.Interpret();
            }
        }
    }
}