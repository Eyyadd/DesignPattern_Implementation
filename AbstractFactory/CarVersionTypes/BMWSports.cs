using AbstractFactory.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarVersionTypes
{
    internal class BMWSports : ISports
    {
        public void DriveFast()
        {
            Console.WriteLine("Driving BMW Sports Fast");
        }
    }
}
