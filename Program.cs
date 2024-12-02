using System;
using NLog;

namespace NlogJourney
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main()
        {
            Logger.Debug("The program has started");

            try
            {
                Logger.Info("Executing main logic...");
                Console.WriteLine("Hello, NLog!");

                throw new Exception("An error occurred");
            }
            catch (Exception ex)
            {

                Logger.Error(ex, "A terrible error occurred");
            }
            finally
            {
                Logger.Info("The program has ended");
            }
        }
    }
}
