using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class MainCup : ICoffe
    {
        public string GetDescription() => " Just Coffe and Some Watter";

        public double GetPrice() => 0.2;
    }
}
