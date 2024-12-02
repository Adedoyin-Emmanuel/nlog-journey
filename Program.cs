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
            Logger.Debug("Connected to database successfully");
            Logger.Fatal("Omor, this one tough o");

            Logger.Warn("Trying to access an undefined variable");
            

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
