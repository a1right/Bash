using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public class BooleanOperators
    {
        private static List<string> _operatorsList;
        public static readonly string True = "0";
        public static readonly string False = "1";

        public static List<string> GetOperatorsList()
        {
            if (_operatorsList == null)
            {
                _operatorsList = new List<string>();
                Type logicalOperators = typeof(BooleanOperators);
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
