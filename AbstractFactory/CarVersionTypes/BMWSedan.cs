using AbstractFactory.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarVersionTypes
{
    internal class BMWSedan : ISedan
    {
        public void DriveComfortably()
        {
            Console.WriteLine("Drive BMW Sedan Comfotably ");
        }
    }
}
