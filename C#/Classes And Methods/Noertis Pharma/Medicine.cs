using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noertis_Pharma
{
    class Medicine
    {
 
        int _medicineCode;
        string _medicineName;
        string _manufacturerName;
        float _price;
        int _quantity;
        DateTime _manufacturedDate;
        DateTime _expiryDate;
        string _batchNumber;

        public Medicine()
        {

        }
       
        public Medicine(int medicineCode, string medicineName, string manufactureName, float price, int quantity, DateTime manufacturedDate, DateTime expiryDate, string batchNumber )
        {
            _medicineCode = medicineCode;
            _medicineName = medicineName;
            _manufacturerName = manufactureName;
            _price = price;
            _quantity = quantity;
            _manufacturedDate = manufacturedDate;
            _expiryDate = expiryDate;
            _batchNumber = batchNumber;
        }
        public void Accept()
        {
            Console.Write("Enter Medicine's code: ");
            _medicineCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Medicine name: ");
            _medicineName = Console.ReadLine();

            Console.Write("Enter Manufacture Name: ");
            _medicineName = Console.ReadLine();

            Console.WriteLine("Enter the price:");
            _price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the quantity on hand:");
            _quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the manufactured date:");
            _manufacturedDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter the expiry date:");
            _expiryDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter the batch number: ");
            _batchNumber = Console.ReadLine();
        }

        public void printMedicine()
        {
            Console.WriteLine("Medicine Name: " + _medicineName);
            Console.WriteLine("Medicine Code: " + _medicineCode);
            Console.WriteLine("Manufacture Name: " + _manufacturerName);
            Console.WriteLine("Manufactured Date: " + _manufacturedDate);
            Console.WriteLine("Expiry Date: " + _expiryDate);
            Console.WriteLine("Batch Number: " + _batchNumber);
        }
    }
}
