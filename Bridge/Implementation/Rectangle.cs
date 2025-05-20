using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementation
{
    public class Rectangle : Shape
    {
        public Rectangle(IColor color) : base(color) { }

        public override void DrawShape()
        {
            Console.WriteLine($"Drwaing Rectangle with color {Color.ApplyColor()}");
        }
    }
}
