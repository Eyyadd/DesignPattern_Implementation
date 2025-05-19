namespace FactoryMethod.Vehicles
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car Start .....");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stop .....");
        }
    }
}
