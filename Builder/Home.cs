using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Home
    {
       public int NumberOfRooms { get; }
       public int NumberOfBathrooms { get; }
       public bool HasGarage { get; }
       public bool HasSwimmingPool { get; }
       public bool HasGarden { get; }
       public string RoofType { get; }
       public string ExteriorColor { get; }
       public string FlooringType { get; }
       public bool HasBasement { get; }
       public bool HasSolarPanels { get; }

        private Home(HomeBuilder builder)
        {
            this.NumberOfBathrooms = builder.NumberOfBathrooms;
            this.NumberOfRooms = builder.NumberOfRooms;
            this.HasGarage = builder.HasGarage;
            this.HasSwimmingPool = builder.HasSwimmingPool;
            this.HasGarden = builder.HasGarden;
            this.HasBasement = builder.HasBasement;
            this.HasSolarPanels = builder.HasSolarPanels;
            this.RoofType = builder.RoofType;
            this.FlooringType = builder.FlooringType;
            this.ExteriorColor = builder.ExteriorColor;
            
        }

        //public int GetNumberOfRooms()
        //{
        //    return this.NumberOfRooms;
        //}

        //public int GetNumberOfBathrooms()
        //{
        //    return this.NumberOfBathrooms;
        //}

        //public bool GetHasGarage()
        //{
        //    return this.HasGarage;
        //}

        //public bool GetHasSwimmingPool()
        //{
        //    return this.HasSwimmingPool;
        //}

        //public bool GetHasGarden()
        //{
        //    return this.HasGarden;
        //}

        //public bool GetHasBasement()
        //{
        //    return this.HasBasement;
        //}

        //public bool GetHasSolarPanels()
        //{
        //    return this.HasSolarPanels;
        //}

        //public string GetRoofType()
        //{
        //    return this.RoofType;
        //}

        //public string GetExteriorColor()
        //{
        //    return this.ExteriorColor;
        //}

        //public string GetFlooringType()
        //{
        //    return this.FlooringType;
        //}

        public class HomeBuilder
        {

            public int NumberOfRooms { get; private set; }
            public int NumberOfBathrooms { get; private set; }
            public bool HasGarage { get; private set; }
            public bool HasSwimmingPool { get; private set; }
            public bool HasGarden { get; private set; }
            public string RoofType { get; private set; } = string.Empty;
            public string ExteriorColor { get; private set; } = string.Empty;
            public string FlooringType { get; private set; } = string.Empty;
            public bool HasBasement { get; private set; }
            public bool HasSolarPanels { get; private set; }

            public HomeBuilder SetNumberOfRooms(int value)
            {
                this.NumberOfRooms = value;
                return this;
            }

            public HomeBuilder SetNumberOfBathrooms(int value)
            {
                this.NumberOfBathrooms = value;
                return this;
            }


            public HomeBuilder SetHasGarage(bool value)
            {
                this.HasGarage = value;
                return this;
            }
            public HomeBuilder SetHasGarden(bool value)
            {
                this.HasGarden = value;
                return this;
            }


            public HomeBuilder SetHasSwimmingPool(bool value)
            {
                this.HasSwimmingPool = value;
                return this;
            }


            public HomeBuilder SetHasBasement(bool value)
            {
                this.HasBasement = value;
                return this;
            }

            public HomeBuilder SetHasSolarPanels(bool value)
            {
                this.HasSolarPanels = value;
                return this;
            }

            public HomeBuilder SetRoofType(string value)
            {
                this.RoofType = value;
                return this;
            }

            public HomeBuilder SetExteriorColor(string value)
            {
                this.ExteriorColor = value;
                return this;
            }

            public HomeBuilder SetFlooringType(string value)
            {
                this.FlooringType = value;
                return this;
            }

            public Home Build()
            {
                if (this.NumberOfRooms <= 0)
                    throw new Exception("number of rooms should be greater than zero");
                return new Home(this);
            }

        }
    }
}
