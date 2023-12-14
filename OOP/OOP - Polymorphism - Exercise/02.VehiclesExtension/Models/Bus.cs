using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models;

namespace Vehicles.Models
{
    public class Bus:Vehicle
    {
        private const double AddedFuelConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, AddedFuelConsumption)
        {
        }
    }
}
