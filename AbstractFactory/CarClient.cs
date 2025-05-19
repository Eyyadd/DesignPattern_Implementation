using AbstractFactory.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class CarClient
    {
        private readonly ISedan _Sedan;
        private readonly ISports _Sports;

        public CarClient(ICarFactory carFactory)
        {
            _Sedan = carFactory.CreateSedan();
            _Sports = carFactory.CreateSports();
        }

        public void TestDrive()
        {
            _Sedan.DriveComfortably();
            _Sports.DriveFast();
        }
    }
}
