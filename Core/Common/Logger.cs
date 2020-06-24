using System;

namespace Core.Common
{
    public class Logger : ILogger
    {
        public void LogDebug(string msg)
        {
            Console.WriteLine($"[{DateTime.Now}] {msg}");
        }
    }
}