﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raiding.IO.Interfaces;

namespace Vehicles.IO
{
    public class FileWriter : IWriter
    {
        public void WriteLine(string str)
        {
            using StreamWriter writer = new("D:\\test.txt", true);

            writer.WriteLine(str);
        }
    }
}
