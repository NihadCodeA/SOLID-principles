﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Bicycle : IVehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Bicycle drive");
        }
    }
}
