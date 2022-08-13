﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash.Operators.BooleanOperators
{
    public class True : IBooleanOperator
    {
        public bool Value { get; } = true;

        public OperatorType OperatorType { get; } = OperatorType.Boolean;

        public string OperatorKey { get; } = "0";
    }
}
