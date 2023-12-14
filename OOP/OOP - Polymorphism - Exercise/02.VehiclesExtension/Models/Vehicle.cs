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
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double addedFuelCons)
        {
            TankCapacity = tankCapacity; //has to be instantiated first because of the fuelQuantity validation
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.addedFuelCons = addedFuelCons;
        }

        public double FuelQuantity 
        {
            get => fuelQuantity;
            private set
            {
                if (TankCapacity < value)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public string Drive(double distance,bool isIncreasedConsumption=true)
        {
            double consumption = isIncreasedConsumption
           ? FuelConsumption + addedFuelCons
           : FuelConsumption;

            if (FuelQuantity < consumption * distance)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            
            }
            FuelQuantity -= distance * consumption;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double amount) 
        {
            if (amount<=0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            if (amount + FuelQuantity> TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            FuelQuantity += amount;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }

    }
}
