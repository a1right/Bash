namespace Bash
{
    public interface IBashMethod
    {
        public bool IsRequireArgs { get; }
        public bool Success { get; }
        public void Execute();
        public void ExecuteWithArgs(string args);


    }
}
