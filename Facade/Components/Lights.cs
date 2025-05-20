using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class Lights
    {
        public void Dim() => Console.WriteLine("Lights Dimming");
        public void Open() => Console.WriteLine("Lights Openning");
    }
}
