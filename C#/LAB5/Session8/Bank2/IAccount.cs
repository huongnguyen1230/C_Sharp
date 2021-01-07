using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public interface IAccount
    {
        bool AcceptDetails();
        double CalculateInterest();
        double GetBalance();
        void Display();
    }
}
