using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class MilkDecorator : ICoffe
    {
        private readonly ICoffe _Coffe;
        public MilkDecorator(ICoffe coffe) => this._Coffe = coffe;

        public string GetDescription() => _Coffe.GetDescription() + " Added Milk ";

        public double GetPrice() => _Coffe.GetPrice() + 0.5;
    }
}
