using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Actions
    {
        private LoggerSingleton _logger = LoggerSingleton.GetInstance();

        public Actions()
        {
        }

        public Result Method1()
        {
            _logger.Log(LogType.Info, "Start Method: Method1");
            return new Result() { Status = true };
        }

        public Result Method2()
        {
            _logger.Log(LogType.Warning, "Skipped logic in method: Method2");
            return new Result() { Status = true };
        }

        public Result Method3()
        {
            _logger.Log(LogType.Error, "I broke a logic");
            return new Result() { Status = false };
        }
    }
}
