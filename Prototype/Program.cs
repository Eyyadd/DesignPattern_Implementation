namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var character_1 = new Character("Rick", 80, 75);
            Console.WriteLine($"character 1 is {character_1}");

            var character_2 = character_1.Clone();
            character_2.Name = "Eyad";
            Console.WriteLine($"character 2 is {character_2}");


        }
    }
}
