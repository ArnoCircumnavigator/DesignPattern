using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14.ChainOfResponsibilityPattern
{
    abstract class AbstractLogger
    {
        public const int INFO  = 1;
        public const int DEBUG = 2;
        public const int ERROR = 3;


        protected int LEVEL { get; set; }
        protected AbstractLogger nextLogger { get; set; }
        public AbstractLogger(int level)
        {
            this.LEVEL = level;
        }
        public void   SetNextLogger(AbstractLogger nextlogger)
        {
            this.nextLogger = nextlogger;
        }

        public void Log(int level, string Message)
        {
            if (this.LEVEL <= level)
            {
                this.write(Message);
                // return;
            }
            if (nextLogger != null)
            {
                nextLogger.Log(level, Message);
            }
        }


        public abstract void write(string message);
    }
}
