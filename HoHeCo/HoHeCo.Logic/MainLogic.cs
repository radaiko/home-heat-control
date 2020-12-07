using HoHeCo.Data;
using HoHeCo.Models;
using RadLogger;
using System;

namespace HoHeCo.Logic
{
    public static class MainLogic
    {
        private static Config _config = new Config();

        public static void Run(ILogger logger, string openhabUrl)
        {
            var openhabReader = new OpenhabReader(logger, openhabUrl);
            logger.LogInfo(openhabReader.GetData().ToString());
        }

        public static string GetOpenhabUrl()
        {
            _config = Config.GetConfig();
            return _config.OpenhabUrl;
        }

        public static void SaveOpenhabUrl(string openhabUrl)
        {
            _config.OpenhabUrl = openhabUrl;
            Config.SaveConfig(_config);
        }
    }
}