using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCP
{
    internal class Student : Person
    {
        public override void GetFullName()
        {
            Console.WriteLine("Student fullname");
        }
    }
}
