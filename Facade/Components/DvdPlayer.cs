using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class DvdPlayer
    {
        public void On() => Console.WriteLine("DVD Player On");
        public void Play() => Console.WriteLine("DVD Player Playing");
        public void Pause() => Console.WriteLine("DVD Player Pause");
        public void Off() => Console.WriteLine("DVD Player Off");
    }
}
