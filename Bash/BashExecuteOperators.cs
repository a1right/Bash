using Bash.BashMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public static class BashExecuteOperators
    {
        public static readonly string Echo = "echo";
        public static readonly string PrintWorkingDirectory = "pwd";
        public static readonly string Cat = "cat";
        public static readonly string PreviousOperationStatus = "$?";

        public static IBashMethod GetBashCommand(string commandName)
        {
            if (commandName == Echo)
                return new Echo();
            return null;
        }
    }
}
