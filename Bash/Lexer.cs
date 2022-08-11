namespace Bash
{
    public class Lexer
    {
        public Command Input { get; private set; }
        public AST SyntaxTree { get; private set; }


        public void Translate()
        {
            ReadInput();
            InitializeSyntaxTree();
            Console.ReadLine();
        }
        
       
        private void ReadInput()
        {
            Input = new Command(Console.ReadLine());
        }
        private void InitializeSyntaxTree()
        {
            var tree = new AST(Input);
            SyntaxTree = tree.Split();
        }
    }
}
