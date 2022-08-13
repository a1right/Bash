using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators
{
    public interface IBooleanOperator : IOperator
    {
        bool Value { get;}
    }
}
