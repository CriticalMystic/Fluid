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
            int i = 0;
            while (i <= message.Length)
            {
                if (message[i].ToString().Equals("§"))
                {
                    foreach (string cc in CC.AllColorCodes)
                    {
                        if((message[i]+message[i+1]).ToString().Equals(cc))
                        {
                            Console.Write(message, LoggerManager.GetConsoleColorByCode(cc));
                        }
                    }
                }
                i++;
            }
        }
    }
}
