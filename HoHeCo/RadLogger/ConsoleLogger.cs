using System;

namespace RadLogger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(EType type, string message)
        {
            switch (type)
            {
                case EType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} ERROR: {1}", DateTime.Now, message);
                    break;

                case EType.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0} Info: {1}", DateTime.Now, message);
                    break;
            }
        }
    }
}