using NLog;
using NLog.Fluent;
using System;

namespace Nlog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Error("Error message");
            logger.Debug("Debug message");
            logger.Info("Info message");

            try
            {
                throw new ArgumentException("Argument Exception");
            }
            catch(Exception ex)
            {
                logger.ErrorException("Error Exception", ex);
            }

            Console.Read();
        }
    }
}
