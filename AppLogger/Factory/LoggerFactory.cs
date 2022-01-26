using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogger.Factory
{
    public class Loggerfactory
    {
        public ILogger GetLogger(string LoggerName)
        {
            switch(LoggerName)           
            {
                case "consolelogger":
                    return new Logger();
                default:
                    throw new Exception("wrong input");
                    
            }
        }
    }
}
