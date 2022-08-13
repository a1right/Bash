using Bash.Operators;

namespace Bash
{
    public class Lexer
    {
        public string Input { get; private set; }
        private List<Command> _commands;
        

        private void Translate()
        {
            ReadInput();
            SplitInput();
        }
        
        public List<Command> GetCommandList()
        {
            Translate();
            return _commands;
        }
        private void ReadInput()
        {
            var input = Console.ReadLine();
            while(CheckInput(input))
            {
                input = Console.ReadLine();
            }
            Input = input;
        }
        private bool CheckInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Empty entry");
                return true;
            }
            return false;
        }
        private void SplitInput()
        {
            var splitedInput = Input.Split(' ');
            if (_commands == null)
            {
                _commands = new List<Command>();
            }
            for(int i = 0; i < splitedInput.Length; i++)
            {
                if (AllOperatorsDictionary.GetOperatorIfExists(splitedInput[i], out IOperator op))
                {
                    
                    var arguments = string.Empty;
                    for (int j = i + 1; j < splitedInput.Length; j++)
                    {
                        if (AllOperatorsDictionary.IsOperator(splitedInput[j]))
                            break;
                        arguments += splitedInput[j];
                    }
                    _commands.Add(new Command(op, arguments));
                }
            }
            foreach(var command in _commands)
            {
                Console.WriteLine($"Оператор: {command.Operator.OperatorKey}\t\t Аргументы: {command.Args}");
            }
        }
       
    }
}
