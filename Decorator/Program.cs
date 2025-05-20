using Decorator.Decorators;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MainCup = new MainCup();
            Console.WriteLine($"The Main Cupe Consist of {MainCup.GetDescription()} and it's price {MainCup.GetPrice()}");

            Thread.Sleep(3000);
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            var AddMilk = new MilkDecorator(MainCup);
            Console.WriteLine($"Now, The Main Cupe Consist of {AddMilk.GetDescription()} and it's price {AddMilk.GetPrice()}");

            Thread.Sleep(3000);
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            var AddSugar = new SugarDecorator(AddMilk);
            Console.WriteLine($"Now, The Main Cupe Consist of {AddSugar.GetDescription()} and it's price {AddSugar.GetPrice()}");

            Thread.Sleep(3000);
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            var AddICE = new IceDecorator(AddSugar);
            Console.WriteLine($"Now, The Main Cupe Consist of {AddICE.GetDescription()} and it's price {AddICE.GetPrice()}");

        }
    }
}
