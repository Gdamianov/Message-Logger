using SolidPrinciplesHomework.Enums;
using SolidPrinciplesHomework.Interfaces;

namespace SolidPrinciplesHomework.Appenders
{
    public abstract class Appender:IAppender, IAppenderLayout 
    {
        public Appender(ILayout layout)
        {
            this.Layout = layout;
        }

        public  ILayout Layout { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string msg, string status);

    }
}
