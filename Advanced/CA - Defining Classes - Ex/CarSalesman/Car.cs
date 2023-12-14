using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            if (Weight == -1)
            {
                return $"{Model}:\n{Engine.ToString()}\n  Weight: n/a\n  Color: {Color}";
            }
            else
            {
                return $"{Model}:\n{Engine.ToString()}\n  Weight: {Weight}\n  Color: {Color}";
            }
        }
    }
}
