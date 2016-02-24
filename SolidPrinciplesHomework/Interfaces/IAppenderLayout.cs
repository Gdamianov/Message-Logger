using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidPrinciplesHomework.Enums;

namespace SolidPrinciplesHomework.Interfaces
{
    public interface IAppenderLayout
    {
        ILayout Layout { get; set; }

        ReportLevel ReportLevel { get; set; }
        
    }
}
