using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int numOne;
            int numTwo;
            int result;
            for(; ;)
            {
                Console.WriteLine("ENter number one");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number two");
                numTwo = Convert.ToInt32(Console.ReadLine());
                result = numTwo + numOne;
                Console.WriteLine("result of addition:" + result);
                Console.WriteLine("do you wish to continue[Y/N]");
                c = Convert.ToChar(Console.ReadLine());
                if(c == 'Y' || c =='y')
                {
                    continue;
                }
                else
                {
                    break;
                }    
            }
        }
    }
}
