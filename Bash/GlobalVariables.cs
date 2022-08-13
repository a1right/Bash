using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bash
{
    public static class GlobalVariables
    {
        private static string currentDirectory;

        public static string CurrentDirectory
        {
            get 
            {
                if (currentDirectory == null)
                {
                    currentDirectory = Environment.CurrentDirectory;
                }
                return currentDirectory;
            }
            set { currentDirectory = value; }
        }
        public static bool LastOperatorReturned { get; set; }
        public static string LastOperatorReturnedName { get; set; }

    }
}
