using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.LogicalOperators
{
    public class And : ILogicalOperator
    {
        public OperatorType OperatorType { get; } = OperatorType.Logical;
        public Priority Priority { get; } = Priority.High;

        public string OperatorKey { get; } = "&&";

        public bool ReturnStatus { get; private set; }

        public bool LeftResult {get; private set; }

        public bool RightResult { get; private set; }

        public bool Result { get; private set; }

        public bool Calculate()
        {
            return LeftResult && RightResult;
        }
    }
}
