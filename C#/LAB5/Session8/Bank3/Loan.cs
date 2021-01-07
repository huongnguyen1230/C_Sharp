using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank3
{
    public abstract class Loan
    {
        protected double LoanAmount;
        protected double InterestAmount;
        protected float InterestRate;
        protected int Duration;

        public virtual void SetValues()
        {
        Duration:
            Console.Write("Enter the pay back period for the loan: ");
            Duration = Convert.ToInt32(Console.ReadLine());

            if(Duration <= 0)
            {
                Console.WriteLine("Pay back period cannot be less than or equal to zero\n");
                goto Duration;
            }
        }

        public abstract double CalculateInterest();
        public abstract void LoanEligibility(double value);

    }
}
