namespace Bash
{
    public class Command
    {
        public string Expression { get; init; }

        public Command(string expression)
        {
            Expression = expression;

        }
    }
}
