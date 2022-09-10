using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class LoggerSingleton
    {
        private static LoggerSingleton _instance;

        private LoggerSingleton()
        {
        }

        public static LoggerSingleton GetInstance()
        {
            if (_instance is null)
            {
                _instance = new LoggerSingleton();
            }

            return _instance;
        }
    }
}
