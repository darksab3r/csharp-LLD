using System;

namespace LLD.ConsoleApp.Singleton.LoggerSingleton
{
    public sealed class Logger : ILogger
    {
        private static ILogger _logger;
        private static readonly object _lock = new object();
        
        private Logger()
        {
        }

        public static ILogger GetInstance()
        {
            if (_logger is null)
            {
                lock (_lock)
                {
                    if (_logger is null)
                    {
                        _logger = new Logger();
                    }
                }
            }

            return _logger;
        }
        public void Info(string message)
        {
            Console.WriteLine("[INFO] " + message);
        }

        public void Debug(string message)
        {
            Console.WriteLine("[DEBUG] " + message);
        }

        public void Error(string message)
        {
            Console.WriteLine("[ERROR] " + message);
        }
    }
}
