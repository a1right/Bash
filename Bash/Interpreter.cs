
using Bash.Operators;
using Bash.Operators.LogicalOperators;
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
            foreach(var command in Input)
            {
                command.Execute(command.Operator, command.Args);
                GlobalVariables.LastOperatorReturned = command.ReturnStatus;
                GlobalVariables.LastOperatorReturnedName = command.Operator.OperatorKey;
            }
        }
    }
}
