using Bash.Operators.LogicalOperators;
using Bash.Operators.BooleanOperators;
using Bash.Operators.ExecuteOperators;

namespace Bash.Operators
{
    public static class AllOperatorsDictionary
    {
        private static Dictionary<string, IOperator> operators = new()
        {
            #region Logical
            {"&&", new And() },
            {"||", new Or() },
            {";", new Both() },
            #endregion
            #region Boolean
            {"0", new True() },
            {"1", new False() },
            #endregion
            #region Execute
            {"echo", new Echo() },
            {"pwd", new PrintWorkingDirectory() },
            {"cd", new ChangeDirectory() },
            #endregion
        };
        public static bool GetOperatorIfExists(string args, out IOperator @operator)
        {
            if (operators.ContainsKey(args))
            {
                @operator = operators[args];
                return true;
            }
            @operator = null;
            return false;
        }
    }
}
