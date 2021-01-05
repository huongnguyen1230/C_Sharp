using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Supplier objSupplier = new Supplier();
            objSupplier.AcceptDetails();

            //integer variable to accept the id of the supplier
            int id = 0;
            //string variable to accept the name of the supplier
            string name = "";

            //accepting the id of the supplier
            Console.Write("\nEnter the id of the suppluer: ");
            id = Convert.ToInt32(Console.ReadLine());

            objSupplier.DisplayDetails(id);

            Console.Write("\nEnter the name of the supplier: ");
            name = Console.ReadLine();

            objSupplier.DisplayDetails(name);

            objSupplier.DisplayDetails(id, name);
        }
    }
}
