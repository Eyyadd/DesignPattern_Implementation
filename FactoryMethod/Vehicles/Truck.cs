namespace FactoryMethod.Vehicles
{
    internal class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Truck Start .....");
        }

        public void Stop()
        {
            Console.WriteLine("Truck Stop .....");
        }
    }
}
