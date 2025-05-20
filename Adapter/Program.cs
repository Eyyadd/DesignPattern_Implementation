namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thirdParty = new ThirdPartyPrintNewFeature();
            IPrint printer = new PrintAdapter(thirdParty);
            printer.Print("Hello From Our New Feature");
        }
    }
}
