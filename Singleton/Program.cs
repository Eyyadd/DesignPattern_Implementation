namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection_1 = DatabaseConnection.GetInstace();
            var connection_2 = DatabaseConnection.GetInstace();

            Console.WriteLine($"Is connection_1 is the same connection_2 ? {connection_1 == connection_2}");
        }
    }
}
