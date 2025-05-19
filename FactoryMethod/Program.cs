using FactoryMethod.Factory;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new CarFactory();
            var vehicle = factory.CreateVehicle();
            vehicle.Start();
            vehicle.Stop();
        }
    }
}
