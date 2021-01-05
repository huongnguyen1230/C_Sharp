using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noertis_Pharma
{
    class Sales
    {
        int _medicineCode;
        int _quantitySold;
        int _plannedSales;
        int _actualSales;
        string _region;

        public Sales()
        {

        }
        public Sales(int medicineCode, int quantitySold, int plannedSales, int actualSales, string region)
        {
            _medicineCode = medicineCode;
            _quantitySold = quantitySold;
            _plannedSales = plannedSales;
            _actualSales = actualSales;
            _region = region;
        }

        public void AcceptSales()
        {
            Console.Write("Enter Medicine's code: ");
            _medicineCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Quantity Sold:");
            _quantitySold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Planned Sales:");
            _plannedSales = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter actual sales:");
            _actualSales = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the region: ");
            _region = Console.ReadLine();
        }

        public void DisplaySales()
        {
           
            Console.WriteLine("Medicine Code: " + _medicineCode);
            Console.WriteLine("Quantity Sold: " + _quantitySold);
            Console.WriteLine("Planned Sales: " + _plannedSales);
            Console.WriteLine("Actual sales: " + _actualSales);
            Console.WriteLine("Region " + _region);
        }
    }
}
