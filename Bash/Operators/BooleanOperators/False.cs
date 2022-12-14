using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.BooleanOperators
{
    public class False : IBooleanOperator
    {
        public bool Value { get; } = false;

        public OperatorType OperatorType { get; } = OperatorType.Boolean;

        public string OperatorKey { get; } = "false";

        public bool ReturnStatus { get; } = false;
        public override string ToString()
        {
            return "1";
        }
    }
}
