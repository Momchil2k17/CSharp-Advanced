using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        
        public Tire(int year, double pr)
        {
            this.Year = year;
            this.Pressure= pr;
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

    }
}
