using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CustomInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattaableLogger : ILogger
    {
        void WriteLog(string format, params Object[] arg);
    }

    class ConsoleLogger2 : IFormattaableLogger
    {
        public void WriteLog(string format, params object[] arg)
        {
            String message = String.Format(format, arg);
            WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }

        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
}
