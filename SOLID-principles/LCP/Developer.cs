using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    internal class Developer : Person , IExperience
    {
        public void GetExperience()
        {
            Console.WriteLine("Developer experince");
        }

        public override void GetFullName()
        {
            Console.WriteLine("Developer fullname");
        }
    }
}
