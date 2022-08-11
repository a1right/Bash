using System.Reflection;

namespace Bash
{

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Lexer lexer = new Lexer();
                lexer.Translate();
            }
        }
    }
}