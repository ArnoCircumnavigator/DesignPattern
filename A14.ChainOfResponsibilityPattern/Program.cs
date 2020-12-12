using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14.ChainOfResponsibilityPattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = GetChainOfLoggers();
            loggerChain.Log(AbstractLogger.INFO, "INFORMATIONG");
            loggerChain.Log(AbstractLogger.DEBUG, "DEBUG");
            loggerChain.Log(AbstractLogger.ERROR, "ERROR");

            Console.ReadLine();
        }
        /// <summary>
        /// 获取责任链的头部
        /// </summary>
        /// <returns></returns>
        static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;//责任链的头部(其实从我的思维惯性上来看，这里应该被称为尾部)
        }
    }
}
