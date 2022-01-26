using AppLogger.Factory;

namespace AppLogger
{
    public class Logger : ILogger
    {
        public void Log(string text) // logs text to console
        {
            Console.WriteLine(text);    
        }
    }
}

