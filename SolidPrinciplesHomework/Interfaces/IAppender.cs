﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesHomework.Interfaces
{
    public interface IAppender
    {
        void Append(string msg, string status);
    }
}
