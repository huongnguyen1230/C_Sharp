using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank3
{
    public class HomeLoan : Loan, IDetails
    {
        private string _borrowerName;
        private string _city;
        private double _annualIncome;
        private double _maxAmount;

        public override void SetValues()
        {
            base.SetValues();
            InterestRate = 15;
        }


        #region IDetails Members
        public void AcceptDetails()
        {
            Console.WriteLine("\t\t\t----HOUSING LOAN DETAILS----\n");
            Console.Write("Enter the borrower's name: ");
            _borrowerName = Console.ReadLine();

            Console.Write("Enter the city: ");
            _city = Console.ReadLine();

        Income:
            Console.Write("Enter the annual income: ");
            _annualIncome = Convert.ToDouble(Console.ReadLine());
            if(_annualIncome <= 0 )
            {
                Console.WriteLine("Annual salary cannot be negative or zero");
                goto Income;
            }

            LoanEligibility(_annualIncome);

            Console.WriteLine("\nMaximum loan amount available: " + _maxAmount + "\n");

        Amount:
            Console.Write("Enter the amount of loan you want: ");
            LoanAmount = Convert.ToInt32(Console.ReadLine());
            if (LoanAmount <= 5000)
            {
                Console.WriteLine("You cannot take a loan of less than 5000 $\n");
                goto Amount;
            }
 
            if (LoanAmount >= _maxAmount)
            {
                Console.WriteLine("Loan Amount cannot be more than the permissible limit\n");
                goto Amount;
            }
        }


        public override void LoanEligibility(double value)
        {
            if(value <=50000)
            {
                _maxAmount = 0;
            }
            else
            {
                _maxAmount = ((value - 50000) * 4);
            }
        }

        double CalculateAmount()
        {
            return (LoanAmount + InterestAmount);
        }
        public void DisplayDetails()
        {
            InterestAmount = CalculateInterest();

            Console.WriteLine("\n\nLOAN DETAILS");
            Console.WriteLine("\nBorrower Name: \t\t" + _borrowerName);
            Console.WriteLine("City: \t\t\t" + _city);
            Console.WriteLine("Annual Income: \t\t" + _annualIncome + "$");
            Console.WriteLine("Loan Amount: \t\t" + LoanAmount + "$");
            Console.WriteLine("Interest Rate: \t\t" + InterestRate + "%");
            Console.WriteLine("Duration of loan: \t" + Duration + "year");
            Console.WriteLine("Total Amount: \t\t" + CalculateInterest() + "$");

        }
        #endregion


        public override double CalculateInterest()
        {
           if((LoanAmount >= 5000) || (LoanAmount <= 100000))
            {
                InterestRate = 9;
            }
           else if ((LoanAmount > 100000) || (LoanAmount <= 250000))
            {
                InterestRate = 9.5F;
            }
           else if((LoanAmount > 250000) || (LoanAmount <= 500000))
            {
                InterestRate = 10;
            }
           else
            {
                InterestRate = 10.5F;
            }
            return ((LoanAmount * Duration * InterestRate) / 100);
        }
    }
}
