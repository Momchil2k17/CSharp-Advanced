using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        private const double DefaultFuelConsumption = 1.25;

        public virtual double FuelConsumption
            => DefaultFuelConsumption;
        public virtual void Drive(double kilometres)
        {
                Fuel -= kilometres * FuelConsumption;
        }


    }
}
