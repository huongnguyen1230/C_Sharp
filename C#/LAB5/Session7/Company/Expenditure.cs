using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    //the program demonstrates the use of override and virtual keywords

    //class Expenditure accepts and displays the expenditure details
    class Expenditure
    {
        //array of string type to store the types of expenditure
        protected string[] expenditureType = { "Maintenance", "Salary Paid", "Miscellaneous" };

        //array of double type to store the amount of expenditure
        protected double[] expenditureAmount = new double[3];

        //double field to store the total expense
        protected double TotalExpenses = 0;

        //method to accept the details of expenditure

        internal virtual void AcceptDetails()
        {
            Console.WriteLine("Enter the expenditure for the following heads:");
            for (int i = 0; i < expenditureType.Length; i++)
            {
                Console.Write(expenditureType[i] + ":");
                expenditureAmount[i] = Convert.ToDouble(Console.ReadLine());
                TotalExpenses += expenditureAmount[i];
            }
        }

        //method to display the details of the expenditure incurred
        internal virtual void DisplayDetails()
        {
            Console.WriteLine("\n\nExpenditure Account");
            Console.WriteLine("\nExpenditure Head\t\tAmount ($)");
            Console.WriteLine("--------------------------------------");

            for (int i = 0; i < expenditureType.Length; i++)
            {
                Console.WriteLine(expenditureType[i] + "\t\t\t" + expenditureAmount[i]);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Total Expenditure\t\t" + TotalExpenses);
        }
    }
}

