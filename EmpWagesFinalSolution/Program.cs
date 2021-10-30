using System;

namespace EmpWagesFinalSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            { //creating an array class object
              //calling all the necessary methods of different classes
                EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                empWageBuilder.addCompanyEmpWage("DMart", 4, 7, 30);
                empWageBuilder.addCompanyEmpWage("Reliance", 5, 30, 25);
                empWageBuilder.addCompanyEmpWage("Ford", 5, 20, 35);
                empWageBuilder.computeEmpWage();
                Console.WriteLine("The total wage for DMart company is :" + empWageBuilder.getTotalWage("DMart"));   //this line queries the total emp wage by the name of the company
            }
        }
    }
}
