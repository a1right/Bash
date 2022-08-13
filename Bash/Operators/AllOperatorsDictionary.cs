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
            {"&&", new And() as ILogicalOperator },
            {"||", new Or() as ILogicalOperator},
            {";", new Both() as ILogicalOperator},
            #endregion
            #region Boolean
            {"True", new True() },
            {"False", new False() },
            #endregion
            #region Execute
            {"echo", new Echo() },
            {"pwd", new PrintWorkingDirectory() },
            {"cd", new ChangeDirectory() },
            {"cls", new ConsoleClear() },
            {"$?", new PrintLastOperationStatus() },
            {"cat", new OpenFile() },

            #endregion
        };
        public static bool IsOperator(string args)
        {
            return operators.ContainsKey(args);
        }
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
