using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Customer
    {
        private short _cusID;
        private string _cusName;
        private byte _age;
        private char _gender;
        private string _city;

        public bool AcceptDetails()
        {
            string input;
            Console.WriteLine("enter cus details:");

            CustomerID:
            try
            {
                try
                {
                    Console.Write("Customer iD: ");
                    _cusID = Convert.ToInt16(Console.ReadLine());
                    if(_cusID <= 0)
                    {
                        Console.WriteLine("Customer ID must br greater than zero\n");
                        goto CustomerID;
                    }
                }
                catch(OverflowException objEx)
                {
                    Console.WriteLine("overfloeException: customer id is too large");
                    Console.WriteLine("Error: { 0}\n", objEx.Message);
                    goto CustomerID;
                }
            CustomerName:
                Console.Write("customer name");
                _cusName = Console.ReadLine();
                if(_cusName == "")
                {
                    Console.WriteLine("invalid customer name\n");
                    goto CustomerName;
                }
                Age:
                try
                {
                    Console.Write("age:");
                    _age = Convert.ToByte(Console.ReadLine());
                    if(_age <= 0)
                    {
                        Console.WriteLine("age cannot be nagetive or zero\n");
                        goto Age;
                    }
                }
                catch(OverflowException objEx)
                {
                    Console.WriteLine("Error: { 0}\n", objEx.Message);
                    goto Age;
                }

            Gender:
                Console.Write("enter gender[M/F]: ");
                input = Console.ReadLine();
                if(input == "male" || input = "Male" || input == "M" || input =="m")
                {
                    _gender = 'M';
                }
                else if(input == "female" || input = "Female" || input == "F" || input == "f")
                {
                    _gender = 'F';
                }
                else
                {
                    Console.WriteLine("Invalid input\n");
                    goto Gender;
                }
            City:
                Console.Write("enter city: ");
                _city = Console.ReadLine();
                if(_city =="")
                {
                    Console.WriteLine("invalid city name\n");
                    goto City;
                }
            }
            catch(FormatException objEx)
            {
                Console.WriteLine("Error: { 0}\n", objEx.Message);
                goto CustomerID;
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: { 0}\n", objEx.Message);
                return false;
            }
            return true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\ncustomer details");
            Console.WriteLine("------------------");
            Console.WriteLine("customer id: {0}", _cusID);
            Console.WriteLine("customer name: {0}", _cusName);
            Console.WriteLine("Age: {0}", _age);

            if (_gender == 'M' || _gender = 'm')
                Console.WriteLine("Male");
            else
                Console.WriteLine("Female");
            Console.WriteLine("City: {0}", _city);
        }
    }
}
