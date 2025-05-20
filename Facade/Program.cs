using Facade.Components;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dvd = new DvdPlayer();
            var soundSystem = new SoundSystem();
            var projector = new Projector();
            var lights = new Lights();

            var HomeSystem = new HomeFacade(dvd, soundSystem, lights, projector);
            HomeSystem.StartMovie();

            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            HomeSystem.PauseMovie();

            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            HomeSystem.CloseMovie();
        }
    }
}
