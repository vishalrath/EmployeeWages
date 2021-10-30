using System;

namespace UC7AssignmentC
{

    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int NUM_WORKING_DAY = 2;
        public const int MAX_HOUR_IN_MONTH = 10;


        public static int computeEmpWage()
        {

            int totalemphour = 0;
            int emphrs = 0;

            int totalW0rkingDay = 0;
            int empwage = 0;
            while (totalemphour <= MAX_HOUR_IN_MONTH && totalW0rkingDay < NUM_WORKING_DAY)
            {

                totalW0rkingDay++;
                // creating obj of Random Predefine class
                Random random = new Random();
                //using Next() to generaret random input out of 0,1
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is FULL Time Present");
                        emphrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Part Time Present");

                        emphrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        emphrs = 0;
                        break;

                }

                totalW0rkingDay += emphrs;
                Console.WriteLine("Days#:" + totalW0rkingDay);  
                     Console.WriteLine("Emp hrs:" + emphrs);
            }

            empwage = emphrs * Emp_Rate_Per_Hour;
            empwage += emphrs;
            Console.WriteLine(" Total Empwage:" + empwage);
            return empwage;
            //Console.ReadLine();
            /*int totalEmpWage = totalemphour * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);*/


        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }  
    }
}