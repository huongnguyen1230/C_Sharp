using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    //class supllierTest is used to instantiate the Supplier class
    class SupplierTest
    {
        //the entry point for the application
        ///<param name="args"> A list of command line arguments </param>
        static void Main(string[] args)
        {
            //creating an object of the Supplier class
            Supllier objSupplier = new Supllier();

            //invoking the AcceptDetails method of the Supplier class
            //to accept the details of the supplier

            objSupplier.AcceptDetails();
        }
    }
}
