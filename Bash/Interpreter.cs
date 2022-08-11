using Bash.BashMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public class Interpreter
    {
        public List<Command> Input { get; init; }
        
        public Interpreter(List<Command> input)
        {
            Input = input;
        }
        public void Interpret()
        {
            ExecuteAll();
        }

        private void ExecuteAll()
        {
            
        }

        private void ExecuteCommand(Command command)
        {
            
        }
    }
}
