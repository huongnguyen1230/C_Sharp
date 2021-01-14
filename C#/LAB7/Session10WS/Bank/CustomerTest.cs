using System;


namespace Bank
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            //creating an object of the customer class
            Customer objCus = new Customer();

            //creating an object of the loan class
            Bank.Finance.Loan objLoan = new Bank.Finance.Loan();

            //invoking the acceptDetails method of the Customer class to accept the details of customer
            if (!objCus.AcceptDetails())
            {
                Console.WriteLine("Invalid Data Entry");
                return;
            }
            else
            {
                if(!objLoan.AcceptDetails())
                {
                    Console.WriteLine("Invalid Data Entry");
                    return;
                }
                else
                {
                    objLoan.CalculateAmount();
                    objCus.DisplayDetails();
                    objLoan.DisplayDetails();
                }
            }
        }
    }
}
