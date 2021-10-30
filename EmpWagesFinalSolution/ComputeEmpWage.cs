using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagesFinalSolution
{
   
        public class CompanyEmpWage
        {
            //variables
            public int empRate;
            public int maxWorkingDay;
            public int maxWorkingHrs;
            public int totalEmpWage;
            public string companyName;

            //Constructor declaration
            public CompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate)
            {
                this.companyName = companyName;
                this.maxWorkingDay = maxWorkingDay;
                this.maxWorkingHrs = maxWorkingHrs;
                this.empRate = empRate;
            }

            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string toString()                     //this method returns the total emp wage of the respected company in string format 
            {
                return "Total Employee Wage For " + this.companyName + " " + "is " + this.totalEmpWage;
            }
        }
    
}