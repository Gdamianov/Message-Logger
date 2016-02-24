using SolidPrinciplesHomework.Appenders;
using SolidPrinciplesHomework.Interfaces;

namespace SolidPrinciplesHomework.Loggers
{
    public class Logger : ILogger, ILoggerAppendable
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public Logger(IAppender appender, IAppender secondAppender)
            : this(appender)
        {
            this.SecondAppender = secondAppender;
        }

        public IAppender Appender { get; set; }
        public IAppender SecondAppender { get; set; }

        public void Info(string msg)
        {
            this.Appender.Append(msg, "Info");
            this.CheckIfFailAppenderIsNull(msg, "Info");
        }

        public void Warn(string msg)
        {
            this.Appender.Append(msg, "Warn");
            this.CheckIfFailAppenderIsNull(msg, "Warn");
        }

        public void Error(string msg)
        {
            this.Appender.Append(msg, "Error");
            this.CheckIfFailAppenderIsNull(msg, "Error");
        }

        public void Critical(string msg)
        {
            this.Appender.Append(msg, "Critical");
            this.CheckIfFailAppenderIsNull(msg, "Critical");
        }

        public void Fatal(string msg)
        {
            this.Appender.Append(msg, "Fatal");
            this.CheckIfFailAppenderIsNull(msg, "Fatal");
        }

        private void CheckIfFailAppenderIsNull(string msg, string status)
        {
            if (this.SecondAppender != null)
            {
                this.SecondAppender.Append(msg, status);
            }
        }

    }
}
