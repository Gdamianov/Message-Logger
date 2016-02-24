using System;
using System.Runtime.InteropServices;
using SolidPrinciplesHomework.Interfaces;

namespace SolidPrinciplesHomework.Appenders
{
    public class ConsoleAppender:Appender
    {
        public ConsoleAppender(ILayout layout):base(layout)
        {
        }

        public override void Append(string msg, string status)
        {
            Console.WriteLine(this.Layout.Format(msg, status));
        }
    }
}
