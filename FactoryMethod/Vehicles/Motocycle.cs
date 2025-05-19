namespace FactoryMethod.Vehicles
{
    internal class Motocycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motocycle Start .....");
        }

        public void Stop()
        {
            Console.WriteLine("Motocycle Stop .....");
        }
    }
}
