using AbstractFactory.CarFactory;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter brand (Toyota/BMW): ");
            string brand = Console.ReadLine();

            ICarFactory factory = brand.ToLower() switch
            {
                "toyota" => new ToyotaFactory(),
                "bmw" => new BMWFactory()
            };

            var client = new CarClient(factory);
            client.TestDrive();
        }
    }
}
