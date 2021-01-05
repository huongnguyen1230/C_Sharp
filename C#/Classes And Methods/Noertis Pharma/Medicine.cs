using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noertis_Pharma
{
    class Medicine
    {
 
        int medicineCode;
        string medicineName;
        string manufacturerName;
        float price;
        int quantity;
        DateTime manufacturedDate;
        DateTime expiryDate;
        string batchNumber;
       

        public void Accept()
        {
            medicineCode = 001;
            medicineName = "abc";
            manufacturerName = "Noertis Pharma";
            price = 30.0F;
            quantity = 100;
            //manufacturedDate = ;
            //expiryDate = ;
            batchNumber = "JK0109";
        }

        public void printMedicine()
        {

        }
    }
}
