using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    //class accepts and displays purchase order details using try-catch blocks
    class PurchaseOrder
    {
        private byte _orderID;
        private DateTime _orderDate;
        private string _customerName;
        private byte _totalQuantity;
        private float _totalAmount;

        //array
        private byte[] productID;
        private string[] productName;
        private byte[] quantity;
        private float[] price;
        private float[] amount;

        public bool AcceptOrderDetails()
        {
            try
            {
                Console.WriteLine("Enter Purchase Order Details: ");

            OrderID:
                Console.Write("Order ID: ");
                _orderID = Convert.ToByte(Console.ReadLine());
                if (_orderID <= 0)
                {
                    Console.WriteLine("Order ID must be greater than zero");
                    goto OrderID;
                }

            OrderDate:
                Console.WriteLine("Order date [DD/MM/YYYY]: ");
                _orderDate = Convert.ToDateTime(Console.ReadLine());
                if (_orderDate > DateTime.Today)
                {
                    Console.WriteLine("Order date cannot be greater than today's date");
                    goto OrderDate;
                }

            CustomerName:
                Console.Write("Customer name: ");
                _customerName = Console.ReadLine();
                if (_customerName == "")
                {
                    Console.WriteLine("Invalid customer name: \n");
                    goto CustomerName;
                }
            }
            catch (Exception objEX)
            {
                Console.WriteLine("Error: {0}", objEX.Message);
                return false;
            }
            return true;
        }

        public bool AcceptProductDetails()
        {
            byte noOfProducts;
            try
            {
            NoOfProducts:
                Console.Write("Enter number of products in purchase order: ");
                noOfProducts = Convert.ToByte(Console.ReadLine());
                if (noOfProducts <= 0)
                {
                    Console.WriteLine("number of products ordered must be greater than zero");
                    goto NoOfProducts;
                }

                productID = new byte[noOfProducts];
                productName = new string[noOfProducts];
                quantity = new byte[noOfProducts];
                price = new float[noOfProducts];
                amount = new float[noOfProducts];

                for (int i = 0; i < noOfProducts; i++)
                {
                ProductID:
                    try
                    {
                        Console.WriteLine("\nEnter Product Details: ");
                        Console.Write("Product ID: ");
                        productID[i] = Convert.ToByte(Console.ReadLine());
                        if (productID[i] <= 0)
                        {
                            Console.WriteLine("Product ID must be greater than zero");
                            goto ProductID;
                        }
                    }
                    catch (FormatException objEx)
                    {
                        Console.WriteLine("Error: {0}\n", objEx.Message);
                        goto ProductID;
                    }

                productName:
                    Console.Write("Product Name: ");
                    productName[i] = Console.ReadLine();
                    if (productName[i] == "")
                    {
                        Console.WriteLine("Invalid product name ");
                        goto productName;
                    }

                    try
                    {
                    Quantity:
                        try
                        {
                            Console.Write("Quantity: ");
                            quantity[i] = Convert.ToByte(Console.ReadLine());
                            if (quantity[i] <= 0)
                            {
                                Console.WriteLine("Quantity of product must be greater than zero");
                                goto Quantity;
                            }
                        }
                        catch (FormatException objEx)
                        {
                            Console.WriteLine("Error: { 0}\n", objEx.Message);
                            goto Quantity;
                        }

                    Price:
                        try
                        {
                            Console.Write("Price: ");
                            price[i] = Convert.ToSingle(Console.ReadLine());
                            if (price[i] <= 0)
                            {
                                Console.WriteLine("Price of product must be greater than zero");
                                goto Price;
                            }
                            amount[i] = quantity[i] * price[i];
                        }
                        catch (FormatException objEx)
                        {
                            Console.WriteLine("Error: { 0}\n", objEx.Message);
                            goto Price;
                        }
                    }


                    catch (OverflowException objEx)
                    {
                        Console.WriteLine("Error: { 0}\n", objEx.Message);
                        return false;
                    }
                }
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: { 0}\n", objEx.Message);
                return false;
            }
                    return true;
                }

                public void CalculateAmount()
                {
                    try
                    {
                        for (int i = 0; i < productID.Length; i++)
                        {
                            _totalQuantity = (byte)(_totalQuantity + quantity[i]);
                            _totalAmount = _totalAmount + amount[i];
                        }
                    }
                    catch (OverflowException objEx)
                    {
                        Console.WriteLine("Error: { 0}\n", objEx.Message);
                    }
                }
                public void DisplayOrderDetails()
                {
                    Console.WriteLine("\nOrder Details: ");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Order ID: {0}", _orderID);
                    Console.WriteLine("Order Date: {0}", _orderDate);
                    Console.WriteLine("Customer Name: {0}", _customerName);
                    Console.WriteLine("Total Quantity: {0}", _totalQuantity);
                    Console.WriteLine("Total Amount: {0:C2}");
                }

                public void DisplayProductDetails()
                {
                    Console.WriteLine("\nProduct Details");
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Product ID \tProduct Name \tQuantity \tPrice \tAmount");
                    for (int i = 0; i < productID.Length; i++)
                    {
                        Console.Write("{0} \t\t{1} \t\t{2} \t\t", productID[i], productName[i], quantity[i]);
                        Console.WriteLine("{0} \t{1}", price[i], amount[i]);
                    }
                }
            }
    }
    
