using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class Projector
    {
        public void On() => Console.WriteLine("Projector on");
        public void Off() => Console.WriteLine("Projector off");
    }
}
