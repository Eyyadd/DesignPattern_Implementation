using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class SugarDecorator(ICoffe coffe) : ICoffe
    {
        private readonly ICoffe _Coffe = coffe;
        public string GetDescription() => _Coffe.GetDescription() + " Added Sugar ";


        public double GetPrice() => _Coffe.GetPrice() + 0.4;
    }
}
