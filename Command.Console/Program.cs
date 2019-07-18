using Command.Business.Service;
using Command.Business.Util;

namespace Command.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var command = string.Empty;
            var commandService = new CommandService();
            while (!command.CompareIgnoreCase("QUIT"))
            {
                System.Console.Write(">>> ");
                command = System.Console.ReadLine();
                var result = commandService.Process(command);
                System.Console.WriteLine(result);
            }
        }
    }
}
