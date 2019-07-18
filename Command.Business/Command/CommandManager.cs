using Command.Business.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business.Command
{
    public static class CommandManager
    {
        public static AbsCommand GetCommand(string commandName)
        {
            if (commandName.CompareIgnoreCase("ADDRULE"))
            {
                return new AddRuleCommand();
            }
            else
            {
                return new AddRuleCommand();
            }
        }
    }
}
