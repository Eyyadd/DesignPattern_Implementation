using Facade.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HomeFacade
    {
        private DvdPlayer _Dvd;
        private SoundSystem _SoundSystem;
        private Lights _Lights;
        private Projector _Projector;

        public HomeFacade(DvdPlayer dvd, SoundSystem soundSystem, Lights lights, Projector projector)
        {
            _Dvd = dvd;
            _SoundSystem = soundSystem;
            _Lights = lights;
            _Projector = projector;
        }

        public void StartMovie()
        {
            Console.WriteLine("Starting Movie");
            _Lights.Dim();
            _Projector.On();
            _SoundSystem.On();
            _SoundSystem.SetVolume(10);
            _Dvd.On();
            _Dvd.Play();
        }

        public void PauseMovie()
        {
            Console.WriteLine("Pausing");
            _Lights.Open();
            _SoundSystem.Mute();
            _Dvd.Pause();
        }

        public void CloseMovie()
        {
            Console.WriteLine("Closing");
            _Lights.Open();
            _SoundSystem.Off();
            _Projector.Off();
            _Dvd.Off();
        }
    }
}
