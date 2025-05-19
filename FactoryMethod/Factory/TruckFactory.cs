using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    internal class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle() => new Truck();
    }
}
