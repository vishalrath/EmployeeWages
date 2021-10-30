using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC10Assignment
{
    class UC10MainClass
    {
        static void Main(string[] args)
        {
            Program DMart = new Program("DMart", 20, 2, 10);
            Program Reliance = new Program("Reliance", 10, 4, 20);
            DMart.computeEmpWage();
            Console.WriteLine(DMart.tostring());
            Reliance.computeEmpWage();
            Console.WriteLine(Reliance.tostring());
        }

    }
}
