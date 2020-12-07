using RadLogger;
using HoHeCo.Logic;
using System;

namespace HoHeCo_Console
{
    internal static class Program
    {
        private static void Main()
        {
            var consoleLog = new ConsoleLogger();
            consoleLog.LogInfo("Welcome to HoHeCo, the Home Heat Control.");
            var openhabUrl = MainLogic.GetOpenhabUrl();
            if (string.IsNullOrWhiteSpace(openhabUrl))
            {
                Console.Write("Insert your openhab URL with port (ex. http://192.168.1.2:8080): ");
                openhabUrl = Console.ReadLine();
            }
            else
            {
                consoleLog.LogInfo(string.Format("We will use existing openhab url: {0}", openhabUrl));
            }

            MainLogic.SaveOpenhabUrl(openhabUrl);
            MainLogic.Run(consoleLog, openhabUrl);
        }
    }
}