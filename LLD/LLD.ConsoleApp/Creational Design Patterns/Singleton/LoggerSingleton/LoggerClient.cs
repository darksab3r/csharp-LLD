namespace LLD.ConsoleApp.Singleton.LoggerSingleton
{
    public class LoggerClient
    {
        public static void Run()
        {
            ILogger logger1 = Logger.GetInstance();
            ILogger logger2 = Logger.GetInstance();
            
            Console.WriteLine(logger1.Equals(logger2));

            logger1.Info("Application started");
            logger1.Debug("Debugging mode enabled");
            logger1.Error("An error occurred");
        }
    }
}
