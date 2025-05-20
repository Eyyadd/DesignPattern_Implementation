using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    internal class SoundSystem
    {
        public void SetVolume(int level) => Console.WriteLine($"Volume Set to level ${level}");
        public void On() => Console.WriteLine("Sound System On");
        public void Mute() => Console.WriteLine("Sound System Muted");
        public void Off() => Console.WriteLine("Sound System Off");
    }
}
