﻿using System;

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

                case EType.Debug:
                    LogDebug(message);
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} Info: {1}", DateTime.Now, message);
        }

        public void LogDebug(string message)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} DEBUG: {1}", DateTime.Now, message);
            }
        }
    }
}