using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementation
{
    public class Red : IColor
    {
        public string ApplyColor()
        {
            return "Apply Red Color ....";
        }
    }
}
