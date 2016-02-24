using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesHomework.Layouts
{
    public class SimpleLayout:Layout
    {
        public override string Format(string message, string status)
        {
            string formattedMsg = string.Format("{0} - {1} - {2}", DateTime.Now, status, message);
            return formattedMsg;
        }
    }
}
