using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall
{

    public delegate void Display(string valueOne, int valueTwo);
    class GiftShop
    {
        private string[] giftItems = { "greeting card", "Puzzle Game", "toy" };
        private float[] pricePerUnit = { 10.20F, 25.12F, 50.78F };
        private int _itemNumber;
        private string _itemName;
        private int _itemSold;
        private double _totalValue;
        private int _availableStock;

        public event Display Print;
        
        public bool AcceptDetails()
        {
            GiftStock objStock = new GiftStock();

            Console.WriteLine("select a gift item\n");
            for(int i = 0; i < giftItems.Length; i++)
            {
                Console.WriteLine((i+1) + "." + giftItems[i]);
            }
            Console.Write("enter your choice(1-3): ");
            try
            {
                _itemNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException objEx)
            {
                Console.WriteLine("Error: " + objEx.Message);
                return false;
            }

            switch(_itemNumber)
            {
                case 1:
                    _itemName = giftItems[0];
                    _availableStock = objStock.totalQuantity[0];
                    Console.WriteLine("Price of" + giftItems[0] + ": " + pricePerUnit[0]);
                    break;
                case 2:
                    _itemName = giftItems[1];
                    _availableStock = objStock.totalQuantity[1];
                    Console.WriteLine("Price of" + giftItems[1] + ": " + pricePerUnit[1]);
                    break;
                case 3:
                    _itemName = giftItems[2];
                    _availableStock = objStock.totalQuantity[2];
                    Console.WriteLine("Price of" + giftItems[2] + ": " + pricePerUnit[2]);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    return false;
            }
        First:
            Console.Write("enter the quantity sold: ");
            try
            {
                _itemSold = Convert.ToInt32(Console.ReadLine());
                if(_itemSold > _availableStock)
                {
                    Console.WriteLine("\nAttention");
                    Console.WriteLine("Maximum stock available: " + _availableStock);
                    goto First;
                }
            }
            catch(FormatException objEx)
            {
                Console.WriteLine("Error: " + objEx.Message);
                return false;
            }
            Subscribe();
            return true;
        }
        public void ValueOfGoods(string name, int number)
        {
            if(name == giftItems[0])
            {
                _totalValue = number * (pricePerUnit[0]);
            }
            else if(name == giftItems[1])
            {
                _totalValue = number * pricePerUnit[1];
            }
            else
            {
                _totalValue = number * pricePerUnit[2];
            }
        }
        void Subscribe()
        {
            Print += new Display(ValueOfGoods);
        }

        public void Invoke()
        {
            Console.WriteLine("\n\nItem Name: " + _itemName);
            if(Print != null)
            {
                Print(_itemName, _itemSold);
                Console.WriteLine("\nTotal Value: (0:F2)", _totalValue);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    }
}
