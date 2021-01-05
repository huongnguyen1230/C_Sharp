using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{

    //the program demonstrates the use of creating a class
    //claa Supllier accepts and displays the details of the supplier
    class Supllier
    {
        //integer filed to store the ID of the supplier.
        private int _supplierID;

        //string filed to store the name of the supplier
        private string _supplierName;

        //string filed to score the city of the supplier.
        private string _city;

        //string filed to store the phone number of the supplier
        private string _phoneNo;

        //string filed to store the email address of the supplier
        private string _email;

        public void AcceptDetails()
        {
            Console.Write("Enter the ID of supllier: ");
            _supplierID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of supplier: ");
            _supplierName = Console.ReadLine();

            Console.Write("Enter the name of city: ");
            _city = Console.ReadLine();

            Console.Write("Enter phone No. : ");
            _phoneNo = Console.ReadLine();

            Console.Write("Enter email address: ");
            _email = Console.ReadLine();
        }

        //method to display the details of the supplier
        public void DisplayDetails()
        {
            Console.WriteLine("\nSupplier Details: ");
            Console.WriteLine("Supplier ID:" + _supplierID);
            Console.WriteLine("Supplier Name:" + _supplierName);
            Console.WriteLine("City: " + _city);
            Console.WriteLine("Phone No: " + _phoneNo);
            Console.WriteLine("Email: " + _email);
        }
        
    }
}
