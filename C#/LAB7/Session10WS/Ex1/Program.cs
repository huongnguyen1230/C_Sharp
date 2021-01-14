using System;
using Bank;

namespace BankTest
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account objAccount = new Account();
            if (objAccount.AcceptDetails())

                objAccount.DisplayDetails();
        }
    }
}
