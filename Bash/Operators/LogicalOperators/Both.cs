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

        public string OperatorKey { get; } = ";";
    }
}
