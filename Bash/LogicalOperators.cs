using System.Collections;
using System.Reflection;

namespace Bash
{
    public static class LogicalOperators
    {
        private static List<string> _operatorsList;
        public static readonly string And = "&&";
        public static readonly string Or = "||";
        public static readonly string Both = ";";

        public static List<string> GetOperatorsList()
        {
            if(_operatorsList == null)
            {
                _operatorsList = new List<string>();
                Type logicalOperators = typeof(LogicalOperators);
                FieldInfo[] operators = logicalOperators.GetFields(BindingFlags.Static | BindingFlags.Public);
                foreach (var op in operators)
                {
                    _operatorsList.Add(op.GetValue(null).ToString());
                }
            }
            return _operatorsList;
        }
    }
    
}
