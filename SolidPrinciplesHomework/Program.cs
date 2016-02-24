using SolidPrinciplesHomework.Appenders;
using SolidPrinciplesHomework.Interfaces;
using SolidPrinciplesHomework.Layouts;
using SolidPrinciplesHomework.Loggers;

namespace SolidPrinciplesHomework
{
    class Program
    {
        static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            ILayout xmLayout = new XMLLayout();

            IAppender consoleAppender = new ConsoleAppender(xmLayout);
            var failAppender = new FileAppender(xmLayout);
            failAppender.FileName = "test.txt";
            ILogger failLogger = new Logger(consoleAppender, failAppender);
            failLogger.Error("test error");

            

           
            
        }
    }
}
