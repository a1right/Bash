using Bash.Operators;

namespace Bash
{
    public class Command: ICommand
    {
        public string Args { get; init; }
        public IOperator @Operator { get; init; }
        public bool ReturnStatus { get; private set; }

        public Command(IOperator @operator)
        {
            Operator = @operator;
        }
        public Command(IOperator @operator, string args)
        {
            @Operator = @operator;
            Args = args;
        }
        public void Execute(IOperator @operator, params string[] args)
        {
            if (@operator.OperatorType == OperatorType.Execute)
            {
                var op = (IExecuteOperator)@operator;
                op.Execute(args);
                ReturnStatus = op.ReturnStatus;
            }
        }
    }
}
