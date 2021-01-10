using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    class MedicinesAvailable
    {
        public int TotalNumberOfMedicines;
        public string MedicineName;
        public DateTime ExpiryDate;
        public string status;

        public MedicinesAvailable()
        {

        }

        public MedicinesAvailable(int _totalNumberOfMedicines, string _medicineName, DateTime exp, string _status)
        {
            TotalNumberOfMedicines = _totalNumberOfMedicines;
            MedicineName = _medicineName;
            ExpiryDate = exp;
            status = _status;
        }
        public void Create()
        {
            Console.Write("Enter total number of medicine: ");
            TotalNumberOfMedicines = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name of the medicine: ");
            MedicineName = Console.ReadLine();

            Console.Write("Enter EXP: ");
            ExpiryDate = Convert.ToDateTime( Console.ReadLine());

            Console.Write("Enter status of the medicine: ");
            status =Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Total number of medicine: " + TotalNumberOfMedicines);
            Console.WriteLine("Name of the medicine: " + MedicineName);
            Console.WriteLine("EXP: " + ExpiryDate);
            Console.WriteLine("Status: " + status);
        }
    }

}
