using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank3
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeLoan objLoan = new HomeLoan();

            objLoan.AcceptDetails();
            objLoan.SetValues();
            objLoan.DisplayDetails();
        }
    }
}
