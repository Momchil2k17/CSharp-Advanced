using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
        public override string ToString()
        {
            if (Displacement == -1)
            {
                return $"  {Model}:\n    Power: {Power}\n    Displacement: n/a\n    Efficiency: {Efficiency}";
            }
            else 
            {
                return $"  {Model}:\n    Power: {Power}\n    Displacement: {Displacement}\n    Efficiency: {Efficiency}";
            }
        }
    }
}
