using Bash.BashMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public static class ExecuteOperators
    {
        private static List<string> _operatorsList;
        public static readonly string Echo = "echo";
        public static readonly string PrintWorkingDirectory = "pwd";
        public static readonly string Cat = "cat";
        public static readonly string PreviousOperationStatus = "$?";

        public static List<string> GetOperatorsList()
        {
            if (_operatorsList == null)
            {
                _operatorsList = new List<string>();
                Type executeOperators = typeof(ExecuteOperators);
                FieldInfo[] operators = executeOperators.GetFields(BindingFlags.Static | BindingFlags.Public);
                foreach (var op in operators)
                {
                    _operatorsList.Add(op.GetValue(null).ToString());
                }
            }
            return _operatorsList;
        }
    }
}
