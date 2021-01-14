using System;
extern alias LibraryOne;
extern alias LibraryTwo;

namespace Bank.Accounts.EmployeeDetails
{
    class Companies
    {
        static void Main(string[] args)
        {
            LibraryOne::Emloyee.Display();
            LibraryTwo::Employee.Display();
        }
    }
}
