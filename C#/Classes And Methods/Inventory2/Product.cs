using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory2
{
    class Product
    {
        //integer filed to store the ID of the product.
        private int _productID;

        //string filed to store the name of the product.
        private string _productName;

        //float filed to store the price of the product.
        private float _price;

        //integer filed to store the stock of the product.
        private int _stock;

        //constructor without paramenters to intialise details of the product

        public Product()
        {
            _productID = 101;
            _productName = "Refrigerator";
            _price = 420.5F;
            _stock = 30;
        }

        //constructor with a single paramenter to initialise details od the product
        public Product(int id)
        {
            _productID = id;
            _productName = "Washing Machine";
            _price = 666.5F;
            _stock = 25;

        }

        public Product(int id, string name, float price, int stock)
        {
            _productID = id;
            _productName = name;
            _price = price;
            _stock = stock;
        }

        //method to display the details of the product
        public void DisplayDetails()
        {
            Console.WriteLine("Product Details: ");
            Console.WriteLine("Product ID: " + _productID);
            Console.WriteLine("Product Name: " + _productName);
            Console.WriteLine("Price: " + _price);
            Console.WriteLine("Quantity in Stock: " + _stock);
        }

    }
}

