using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagesFinalSolution
{
    public interface IComputeEmpWage                                 //declaration of the interface class
    {
        /// <summary>
        /// Adds the company emp wage.
        /// </summary>
        /// <param name="companyName">Name of the company.</param>
        /// <param name="maxWorkingDay">The maximum working day.</param>
        /// <param name="maxWorkingHrs">The maximum working HRS.</param>
        /// <param name="empRate">The emp rate.</param>
        public void addCompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate);
        public void computeEmpWage();                       //method declaration as in innterface, we cant define the methods as of that in abstract class
        public int getTotalWage(string company);

    }
    public class EmpWageBuilder : IComputeEmpWage                     //inheriting from the interfce class
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;  //initialising the dictionary object with string as key and the companyempwage class as value
        private LinkedList<CompanyEmpWage> companyEmpWageList;           //initialising the Linkedlist of the referrence type CompanyEmpWage class which holds 
                                                                         //all the data about the various variables in it.

        public EmpWageBuilder()                                    //declaring the array size 
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        //method to insert into the array
        public void addCompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate)  //completeing the interfaced method
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, maxWorkingDay, maxWorkingHrs, empRate); //creating emp wage object of the company emp wage class
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(companyName, companyEmpWage);

            //in the above lines of code we are putting the add methods in both the lisrt and dictionary
        }
        public void computeEmpWage()                                                     //similar method like compute emp wage just that it fethces a single element and then finds out its respected emp wage(total)
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));    //this will fetch the companyEmpWage object from the list,and the ComputeEmpWage method will execute its job with the help of the object's variable
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage Company)                                  //the main computing method
        {
            int empWage = 0;
            int totalWorkingDay = 0;
            int totalWorkingHrs = 0;
            int empHr = 0;

            //while loop programming construct
            while (totalWorkingDay < Company.maxWorkingDay && totalWorkingHrs <= Company.maxWorkingHrs)
            {
                //used predefined Random class
                Random attendance = new Random();
                int empInput = attendance.Next(0, 3);
                //various switch cases to access the empInput and change the emp hours accordingly
                switch (empInput)
                {
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;


                    case IS_PART_TIME:
                        empHr = 4;
                        break;

                    default:
                        empHr = 0;
                        break;
                }

                // Formula for calculating employe wage
                empWage = Company.empRate * empHr;
                //formula for calculating total emloyee wage
                Company.totalEmpWage = Company.totalEmpWage + empWage;
                //incrementation
                totalWorkingDay++;
                totalWorkingHrs = totalWorkingHrs + empHr;

            }

            Console.WriteLine("Total Working Days: {0}, Total Working Hrs: {1}", totalWorkingDay, totalWorkingHrs);
            return Company.totalEmpWage;

        }

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}

