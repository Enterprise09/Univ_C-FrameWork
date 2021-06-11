using System;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormattaableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat");
            logger.WriteLog("{0} + {1} + {2}", 1, 1, 2);
        }
    }
}
