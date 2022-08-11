namespace Bash.BashMethods
{
    public class Echo : IBashMethod
    {
        public bool IsRequireArgs { get; } = true;
        public bool Success { get; private set; } = false;

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void ExecuteWithArgs(string args)
        {
            Console.WriteLine(args);
            Success = true;
        }
    }
}
