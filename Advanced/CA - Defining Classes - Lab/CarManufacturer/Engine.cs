using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
		public Engine(int hp,double cc) 
		{
			this.HorsePower = hp;
			this.CubicCapacity = cc;
		}
		private int horsePower;

		public int HorsePower
		{
			get { return horsePower; }
			set { horsePower = value; }
		}

		private double cubicCapacity;

		public double CubicCapacity
		{
			get { return cubicCapacity; }
			set { cubicCapacity = value; }
		}


	}
}
