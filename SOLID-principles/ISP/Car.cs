using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Car : IVehicle, IFueled
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public double CurrentFuel { get; set; }
        public double Fuel { get; set; }

        public void AddFuel()
        {
            Console.WriteLine("Add fuel");
        }

        public void Drive()
        {
            Console.WriteLine("Car drive");
        }
    }
}
