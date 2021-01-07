using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class RevenueTest
    {
        //the entry point for the application
        static void Main(string[] args)
        {
            //creating an object of the revenue class
            Revenue obj = new Revenue();
            //creating an object of the expediture class
            Expenditure objEx = new Expenditure();


            //invoking the acceptDetails is method of the expenditure class
            //to accept the details of expenditure
            objEx.AcceptDetails();

            obj.AcceptDetails();
            obj.DisplayDetails();
        }
    }
}
