namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var homebuilder = new Home.HomeBuilder()
                                      .SetNumberOfRooms(3)
                                      .SetNumberOfBathrooms(2)
                                      .SetExteriorColor("Bage")
                                      .SetFlooringType("Ceramic")
                                      .SetHasBasement(true)
                                      .SetHasGarage(false)
                                      .SetHasSolarPanels(false)
                                      .SetHasSwimmingPool(true)
                                      .SetRoofType("Soft")
                                      .SetHasGarden(true)
                                      .Build();

            Console.WriteLine("Home has Garden ? {0}", homebuilder.HasGarden);
            Console.WriteLine("Home has Swimmingpool ? {0}", homebuilder.HasSwimmingPool);
            Console.WriteLine("Home has SolarPanels ? {0}", homebuilder.HasSolarPanels);
            Console.WriteLine("Home has  Basement ? {0}", homebuilder.HasBasement);
            Console.WriteLine("Home has Garage ? {0}", homebuilder.HasGarage);
            Console.WriteLine("Home has {0} Rooms", homebuilder.NumberOfRooms);
            Console.WriteLine("Home has {0} Bathrooms", homebuilder.NumberOfBathrooms);
            Console.WriteLine("Home Floor type is {0}", homebuilder.FlooringType);
            Console.WriteLine("Home Roof type is {0}", homebuilder.RoofType);
            Console.WriteLine("Home Color is {0}", homebuilder.ExteriorColor);
        }
    }
}
