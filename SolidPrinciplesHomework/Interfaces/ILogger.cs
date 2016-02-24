using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesHomework.Interfaces
{
    public interface ILogger
    {

        void Info(string msg);

        void Warn(string msg);

        void Error(string msg);

        void Critical(string msg);

        void Fatal(string msg);
    }
}
