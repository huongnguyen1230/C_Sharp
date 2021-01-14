using IO = System.Console;
using Emp = Bank.Accounts.EmployeeDetails;

namespace Bank.Accounts.EmployeeDetails
{
    class AliasExample
    {
        static void Main(string[] args)
        {
            Emp.Employee obj = new Emp.Employee();
            obj.EmpName = " peter";
            IO.WriteLine("employee name: " + obj.EmpName);
        }
    }
}
