using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact
{
    public class Employee
    {
        public int EmpID;
    }
    namespace Salary
    {
        public class SalaryDetails
        {
            public double EmpSalary;
        }
    }
    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            Contact.Salary.SalaryDetails objS = new Contact.Salary.SalaryDetails();
            objS.EmpSalary = 1000.50;
            Console.WriteLine("Salary" + objS.EmpSalary);
        }
    }
}
