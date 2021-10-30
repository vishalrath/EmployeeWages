using System;

namespace UC4Assignment
{
    class Program
    {
       public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int Emp_Rate_Per_Hour = 20;
        static void Main(string[] args)
        {
            int emphrs = 0;
            int empwage = 0;
            // creating obj of Random Predefine class
            Random random = new Random();
            //using Next() to generaret random input out of 0,1
            int empcheck = random.Next(0, 3);
            
            switch(empcheck)
            {
                case IS_FULL_TIME:

                    emphrs = 8;
                    break;
                case IS_PART_TIME:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;

            }
            empwage = emphrs * Emp_Rate_Per_Hour;
            Console.WriteLine("empwagec:" + empwage);


            Console.ReadLine();

        }
    }
}
