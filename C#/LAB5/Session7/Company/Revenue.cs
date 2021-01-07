using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    //class revenue inhertis the Expenditure class
    //class revenue accepts the total revenue, display details, calculates profit
    class Revenue: Expenditure
    {
        //double field to store the total income
        private double _totalIncome;

        //double field to store the difference total income and total expenses
        private double _balance;
        //method to accept the total income
        //the method overrides the method of the base class using the override keyword
        internal override void AcceptDetails()
        {
            Console.WriteLine("\n");
            base.AcceptDetails();
            Console.WriteLine("\nEnter the nevenue earned annually: ");
            _totalIncome = Convert.ToDouble(Console.ReadLine());

        }

        internal override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("\nTotal Income\t\t\t" + _totalIncome);
            _balance = _totalIncome - TotalExpenses;

            if(_balance < 0)
            {
                Console.WriteLine("\nNet Loss: " + -_balance + "\n");
            }
            else
            {
                Console.WriteLine("\nNet Profit: " + _balance + "\n");
            }
        }
    }
}
