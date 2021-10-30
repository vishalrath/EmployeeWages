using System;

namespace UC13empWagesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an array class object
            //calling all the necessary methods of different classes
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 4, 7, 30);
            empWageBuilder.addCompanyEmpWage("Reliance", 5, 30, 25);
            empWageBuilder.addCompanyEmpWage("Ford", 5, 20, 35);
            empWageBuilder.computeEmpWage();
        }
    }
}
