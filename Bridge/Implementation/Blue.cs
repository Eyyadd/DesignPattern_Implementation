﻿using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementation
{
    public class Blue : IColor
    {
        public string ApplyColor()
        {
            return "Apply Blue Color ....";
        }
    }
}
