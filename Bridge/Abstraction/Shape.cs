using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Abstraction
{
    public abstract class Shape
    {
        protected IColor Color;
        protected Shape(IColor color) => Color = color;
        public abstract void DrawShape();
    }
}
