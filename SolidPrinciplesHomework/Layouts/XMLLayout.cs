using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesHomework.Layouts
{
    public class XMLLayout:Layout
    {
        public override string Format(string message, string status)
        {
            StringBuilder formatedMessage = new StringBuilder();
            formatedMessage.Append("<log>");
            formatedMessage.AppendLine(string.Format("  <date>{0}</date>", DateTime.Now));
            formatedMessage.AppendLine(string.Format("  <level>{0}</level>", status));
            formatedMessage.AppendLine(string.Format("  <message>{0}</message>", message));
            formatedMessage.AppendLine("</log>");
            return formatedMessage.ToString();
        }
    }
}
