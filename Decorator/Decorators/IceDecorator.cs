using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class IceDecorator(ICoffe coffe) : ICoffe
    {
        private readonly ICoffe _Coffe = coffe;

        public string GetDescription() => _Coffe.GetDescription() + " Add Ice to be ICE Coffe ";

        public double GetPrice() => _Coffe.GetPrice() + 0.8;
    }
}
