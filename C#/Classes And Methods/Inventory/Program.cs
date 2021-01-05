using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    //the program demonstrates the use of method
    class Supplier
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
        //method to accept the details of the supplier

        internal void AcceptDetails()
        {
            Console.Write("Enter the ID of supplier: ");
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

        internal void DisplayDetails(int supplierID)
        {
            Console.WriteLine("Supplier ID: " + supplierID);
        }

        internal void DisplayDetails(string supplierName)
        {
            Console.WriteLine("Supplier Name: " + supplierName);
        }

        internal void DisplayDetails(int supplierID, string supplierName)
        {
            Console.WriteLine("\nSupplier {0} with ID {1} lives in city {2}", supplierName, supplierID, _city);
        }
    }
}
