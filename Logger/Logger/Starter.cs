using System;
using System.IO;

namespace Logger
{
    public class Starter
    {
        private Actions _actions = new Actions();
        private LoggerSingleton _logger = LoggerSingleton.GetInstance();
        private Result _result;
        private static string _path = @"C:\PROG\C#\Homework\Modul2_HW1\Logger\log.txt";

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                switch (new Random().Next(1, 4))
                {
                    case 1:
                        _result = _actions.Method1();
                        break;
                    case 2:
                        _result = _actions.Method2();
                        break;
                    case 3:
                        _result = _actions.Method3();
                        break;
                }

                if (_result.Status is false)
                {
                    _logger.Log(LogType.Error, $"Action failed by a reason: {_result.TextError}");
                }
            }

            Console.WriteLine(_logger.DatabaseLogs);
            File.WriteAllText(_path, _logger.DatabaseLogs.ToString());
        }
    }
}
