﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product objProduct = new Product();

            Console.Write("Enter the Customer Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the invoice number: ");
            int value = Convert.ToInt32(Console.ReadLine());

            objProduct.SetDetails(value, name);

            objProduct.SetDetails();

            objProduct.Display();
        }
    }
}
