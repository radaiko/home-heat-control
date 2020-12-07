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
                    LogError(message);
                    break;

                case EType.Info:
                    LogInfo(message);
                    break;
            }
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} ERROR: {1}", DateTime.Now, message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0} Info: {1}", DateTime.Now, message);
        }
    }
}