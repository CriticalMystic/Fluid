using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluid.Core.Logger
{
    public class ServerLogger : LoggerManager
    {
        public static void Info(string message)
        {
            Console.Write("[Server]: ");
            foreach("§")
            
            Console.Write(message, ConsoleColor.Red);
        }
    }
}
