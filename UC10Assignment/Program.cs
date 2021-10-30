using System;

namespace UC10Assignment
{
    public class Program
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        private string Company;
        private int empRate_Per_hour;
        private int NoofWorkingDays;
        private int MaxHourPerMonth;
        private int empwage;
        public Program(string Company, int empRate_Per_hour, int NoofWorkingDays, int MaxHourPerMonth)
        {
            this.Company = Company;
            this.empRate_Per_hour = empRate_Per_hour;
            this.NoofWorkingDays = NoofWorkingDays;
            this.MaxHourPerMonth = MaxHourPerMonth;
        }
        public void computeEmpWage()
        {
            int totalemphour = 0;
            int emphrs = 0;

            int totalW0rkingDay = 0;
            //int empwage = 0;
            while (totalemphour <= this.MaxHourPerMonth && totalW0rkingDay < this.NoofWorkingDays)
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
                totalemphour += emphrs;

                //totalW0rkingDay += emphrs;//
                Console.WriteLine("Days#:" + totalW0rkingDay);
                Console.WriteLine("Emp hrs:" + emphrs);
            }


            empwage = emphrs * this.empRate_Per_hour;
            empwage += emphrs;
            Console.WriteLine(" Total Empwage for company :" + Company + "is" + empwage);
        }
        public string tostring()
        {
            return "Total Emp Wage of Company:" + this.Company + "Is :" + this.empwage;
        }
    }

}
