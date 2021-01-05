using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory2
{
    class ProductTest
    {
        //the entry point for the application
        static void Main(string[] args)
        {
            //creating an object of the Product class and invoking the default
            //contructor without paramenters
            Product objProduct = new Product();

            //invoking the DisplayDetails method of the Product class to display the details of the product
            objProduct.DisplayDetails();
            Console.WriteLine();

            //creating an object of the Product class and invoking 
            //a paramenterised constructor with a single parameters

            Product objProduct1 = new Product(102);
            objProduct1.DisplayDetails();
            Console.WriteLine();

            Product objProduct2 = new Product(103, "Television", 5660.45F, 60);
            objProduct2.DisplayDetails();


        }
    }
}
