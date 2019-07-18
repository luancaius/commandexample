using Command.Business.Action;
using Command.Business.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business.Service
{
    public class CommandService
    {
        public string Process(string command)
        {
            //validate input
            var list = command.Split().ToList();
             var commandName = list[0];
            list.RemoveAt(0);
            var commandObj = CommandManager.GetCommand(commandName);
            commandObj.Execute(list);

            return string.Empty;
        }
    }
}
