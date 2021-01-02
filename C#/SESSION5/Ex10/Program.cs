using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] companies = new string[3][];
            companies[0] = new string[] { "Intel", "AMD" };
            companies[1] = new string[] { "IMB", "Microsoft" };
            companies[2] = new string[] { "HP", "Canon", "Lexmark", "Epson" };
            for (int i = 0; i < companies.GetLength(0); i++)
            {
                Console.WriteLine("List of companies in group" + (i + 1));
            }
            Console.WriteLine();
        }
    }
}
