using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Crocodile obj = new Crocodile();
            string terCroc = obj.EatTerrestrial();
            Console.WriteLine(terCroc);
            string marCroc = obj.EatMarine();
            Console.WriteLine(marCroc);
        }
    }
}
