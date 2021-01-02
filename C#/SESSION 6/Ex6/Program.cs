using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        public static void Addition(int val1, int val2)
        {
            Console.WriteLine(val1 + val2);
        }
        public void Multiply(int val1, int val2)
        {
            Console.WriteLine(val1 * val2);
        }
    }
    class StaticMethods
        {
        static void Main(string[] args)
        {
            Program.Addition(10, 50);
            Program objCal = new Program();
            objCal.Multiply(10, 20);
        }
    }
}
