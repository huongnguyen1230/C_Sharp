using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class CustomerTest
    {
        static void Main(string[] args)
        {
            try
            {
                Customer objCus = new Customer();

                if (objCus.AcceptDetails())
                {
                    objCus.DisplayDetails();
                }
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: {0}", objEx.Message);
            }
        }
    }
}
