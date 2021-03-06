﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class SavingsAccount:Account
    {
        private float _minBalance;
        private float _bankCharge;

        public bool Flag = true;
        public bool AcceptDetails()
        {
            string name;
            long number;
            double amount;

            Console.Write("Enter the customer name: ");
            name = Console.ReadLine();

        First:
            Console.Write("Enter the account number: ");
            number = Convert.ToInt64(Console.ReadLine());

            if(number <= 0)
            {
                Console.WriteLine("Invalid Account Number");
                goto First;
            }
            else
            {
                SetDetails(name, number);
            }

            Console.WriteLine("\nInitial balance available: " + Balance + "\n\n");

            Console.WriteLine("Select the type of transaction: ");
            Console.WriteLine("1. Withdraw \n 2. Deposit");
            Console.WriteLine("Select your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Minimun balance to be mantained: " + _minBalance + "$\n");
                    Console.Write("Enter the amount to be withdraw: ");
                    amount = Convert.ToDouble(Console.ReadLine());
                    Withdraw(amount);
                    break;
                case 2:
                    Console.WriteLine("Enter the amount to be deposit: " + _minBalance + "$\n");
                    amount = Convert.ToDouble(Console.ReadLine());
                    Deposit(amount);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    return false;
            }
            if (!Flag)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void SetDetails( string name, long number)
        {
            base.SetDetails(name, number);
            _minBalance = 500;
        }

        protected override double BankCharges()
        {
            if(Balance < _minBalance)
            {
                _bankCharge = 200;
            }
            return _bankCharge;
        }

        protected override void Deposit(double amount)
        {
            base.Deposit(amount);
        }

        protected override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("You do not have sufficient balance in your account");
                Flag = false;
                return;
            }
        }

        public override void Display()
        {
            base.Display();

            if(Balance <= 500)
            {
                Console.WriteLine("\nBank Charges for less than minimun balance: " + BankCharges());
            }
        }
    }
}
