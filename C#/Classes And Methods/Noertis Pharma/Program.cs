using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noertis_Pharma
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine objMedicine = new Medicine();
            objMedicine.printMedicine();

            Medicine objMedicine2 = new Medicine(001, "abc", "Noertis Pharma", 30.0F, 100, new DateTime(13 / 06 / 2013), new DateTime(13 / 06 / 2021), "JK97");
            objMedicine2.printMedicine();

            Sales objSales = new Sales();
            objSales.DisplaySales();

            Sales objSale2 = new Sales(001, 20, 70, 55, "Ha Noi");
            objSales.DisplaySales();

        }
    }
}
