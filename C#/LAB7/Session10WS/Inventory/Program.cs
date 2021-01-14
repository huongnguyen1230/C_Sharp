using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class PurchaseOrderTest
    {
        static void Main(string[] args)
        {
            PurchaseOrder objPO;

        AcceptOrder:
            char choice = 'N';
            try
            {
                objPO = new PurchaseOrder();

                if (objPO.AcceptOrderDetails())
                {
                    if(objPO.AcceptProductDetails())
                    {
                        objPO.CalculateAmount();
                        objPO.DisplayOrderDetails();
                        objPO.DisplayProductDetails();
                        
                    }
                }
            }
            catch(Exception objEx)
            {
                Console.WriteLine("Error: { 0}\n", objEx.Message);
            }

            finally
            {
                try
                {
                    objPO = null;
                    Console.Write("\nDo you want to add details for another purchase order[Y/N]");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                catch(Exception objEx)
                {
                    Console.WriteLine("Error: { 0}\n", objEx.Message);
                }
            }
            if (choice == 'Y' || choice = 'y')
                goto AcceptOrder;
        }
    }
}
