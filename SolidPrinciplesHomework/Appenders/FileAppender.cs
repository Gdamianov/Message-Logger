namespace SolidPrinciplesHomework.Appenders
{
    using System;
    using System.IO;
    using SolidPrinciplesHomework.Interfaces;

    public class FileAppender:Appender, IFileAppender
    {
        public FileAppender(ILayout layout):base(layout)
        {
        }

        public string FileName { get; set; }

        public override void Append(string msg, string status)
        {
            if (string.IsNullOrEmpty(this.FileName))
            {
                throw new InvalidOperationException("file name cannot be null");
            }
            using (StreamWriter writer =
                    new StreamWriter(this.FileName))
            {
                writer.Write(this.Layout.Format(msg, status));
               
            }
        }

    }
}
