using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        void printMessage(string message = "Hello user!")
        {
            Console.WriteLine("{0}", message);
        }
        static void Main(string[] args)
        {
            Program opExample = new Program();
            opExample.printMessage("Welcome User!");
            opExample.printMessage();
        }
    }
}
