using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class Product: Invoice
    {
        private string _productName;
        private int _quantity;
        private double _price;
        private double _totalValue;

        public override void SetDetails()
        {
            base.SetDetails();
            Console.Write("Enter the product name: ");
            _productName = Console.ReadLine();

        Sale:
            Console.Write("Enter the quantity sold: ");
            _quantity = Convert.ToInt32(Console.ReadLine());

            //validating the quantity of the product
            if(_quantity<0)
            {
                Console.WriteLine("Quantity cannot be negative");
                goto Sale;
            }

        _Price:
            Console.Write("Enter the price per unit: ");
            _price = Convert.ToDouble(Console.ReadLine());

            if(_price < 0)
            {
                Console.WriteLine("Price cannot be negative");
                goto _Price;
            }
            _totalValue = _quantity * _price;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\nPRODUCT DETAILS");
            Console.WriteLine("\nProduct: " + _productName);
            Console.WriteLine("Quantity Sold: " + _quantity);
            Console.WriteLine("Peice per unit:\t " + _price);
            Console.WriteLine("Total Amount: \t" + _totalValue);
        }
    }
}
