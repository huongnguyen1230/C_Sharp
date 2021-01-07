using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount obj = new SavingsAccount();

            if(obj.AcceptDetails())
            {
                obj.Display();
            }
            else
            {
                return;
            }

        }
    }
}
