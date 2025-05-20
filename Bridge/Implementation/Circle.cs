using Bridge.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Implementation
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }
        public override void DrawShape()
        {
            Console.WriteLine($"Drwaing Circle with color {Color.ApplyColor()}");
        }
    }
}
