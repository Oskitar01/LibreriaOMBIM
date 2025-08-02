using System;
using NLog;

namespace LibreriaOMBIM
{
    public static class LoggerHelper
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void Info(string message)
        {
            logger.Info(message);
        }

        public static void Warn(string message)
        {
            logger.Warn(message);
        }

        public static void Error(string message, Exception ex = null)
        {
            if (ex != null)
                logger.Error(ex, message);
            else
                logger.Error(message);
        }
    }
}
