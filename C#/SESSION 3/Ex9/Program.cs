using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            quantity = Console.Read();
            int price;
            price = Console.Read();
            if ((quantity == 2000) ^ (price == 10.5))
            {
                Console.WriteLine("You have to compromise between quantity and price");
            }
        }
    }
}
