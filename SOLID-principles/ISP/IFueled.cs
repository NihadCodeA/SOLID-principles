using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IFueled
    {
        public double CurrentFuel { get; set; }
        public double Fuel { get; set; }

        void AddFuel();
    }
}
