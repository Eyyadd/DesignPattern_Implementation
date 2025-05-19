using AbstractFactory.CarVersionTypes;
using AbstractFactory.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CarFactory
{
    internal class ToyotaFactory : ICarFactory
    {

        public ISedan CreateSedan() => new ToyotaSedan();

        public ISports CreateSports() => new ToyotaSports();
    }
}
