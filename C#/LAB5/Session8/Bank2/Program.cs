using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedAccount obj = new FixedAccount();
            Console.WriteLine("\t\t\tFIXED ACCOUNT DETAILS\n");

            char choice;
            do
            {
                if (!obj.AcceptDetails())
                {
                    return;
                }
                else
                {
                    obj.Display();
                }
                Console.Write("\nDo you wish to continue [Y|N]: ");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            }
            while ((choice == 'y') || (choice == 'Y'));
        }
    }
}
