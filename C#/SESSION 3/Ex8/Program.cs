using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            quantity = Console.Read();
            int price;
            price = Console.Read();
            if ((quantity == 2000) | (price == 10.5))
            {
                Console.WriteLine("The goods are correctly prices");
            }
        }
    }
}
