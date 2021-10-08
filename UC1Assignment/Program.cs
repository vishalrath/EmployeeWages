using System;

namespace UC1Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Present = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (Is_Present == empInput)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine(" Employee is Absent");
            }
        }
    }
}
