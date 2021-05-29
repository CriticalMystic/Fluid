using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluid.Core.Logger
{
    class ServerLogger : LoggerManager
    {
        public static void Info(string message)
        {
            Console.WriteLine($"[Server]: {message}");
        }
    }
}
