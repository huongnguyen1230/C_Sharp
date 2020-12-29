using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            string msg = "";
            if (num < 0)
            {
                msg = "the number" + num + "is negative";
            }
            else if((num % 2) == 0)
            {
                msg = "the number" + num + "is even";
            }
            else
            {
                msg = "the number" + num + "is odd";
            }
            if (msg != "")
                Console.WriteLine(msg);
        }
    }
}
