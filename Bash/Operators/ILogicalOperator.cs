using Bash.Operators.LogicalOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators
{
    public interface ILogicalOperator : IOperator
    {
        Priority Priority { get; }
        bool LeftResult { get; }
        bool RightResult { get; }
        bool Result { get; }
        public bool Calculate();
        public bool SetLeftResult(bool returnStatus);
        public bool SetRightResult(bool returnStatus);
    }
}
