using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Vehicle : IVehicle
    {
        private double addedFuelCons;

        public Vehicle(double fuelQuantity, double fuelConsumption,double addedFuelCons)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.addedFuelCons = addedFuelCons;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double fullConsumption = FuelConsumption + addedFuelCons;
            if (FuelQuantity<fullConsumption*distance)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            FuelQuantity -= distance * fullConsumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double amount) => FuelQuantity += amount;
        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }

    }
}
