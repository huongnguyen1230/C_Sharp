using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[3] { "Ashley", "Joe", "Mike" };
            foreach(string studName in studentNames)
            {
                Console.WriteLine("Congratulations!!" + studName + " you have been granted an extra leave");
            }
        }
    }
}
