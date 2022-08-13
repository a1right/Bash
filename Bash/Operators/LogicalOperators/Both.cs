using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.LogicalOperators
{
    public class Both : ILogicalOperator
    {
        public OperatorType OperatorType { get; } = OperatorType.Logical;
        public Priority Priority { get; } = Priority.Low;
        public string OperatorKey { get; } = ";";

        public bool ReturnStatus { get; private set; }

        public bool LeftResult { get; private set; }

        public bool RightResult { get; private set; }

        public bool Result { get; private set; }

        public bool Calculate()
        {
            return true;
        }
    }
}
