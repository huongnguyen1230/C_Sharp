using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    class infoPersonnel
    {
        public int perID;
        public string perName;
        public DateTime DOB;
        public string rank;

        public infoPersonnel()
        {

        }

        public infoPersonnel(int _ID, string _name, DateTime _DOB, string _rank)
        {
            this.perID = _ID;
            this.perName = _name;
            this.DOB = _DOB;
            this.rank = _rank;
        }

        public void CreateInfo()
        {
            Console.Write("Enter ID of the personnel: ");
            perID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name of the personnel: ");
            perName = Console.ReadLine();

            Console.Write("Enter date of birth ");
           DOB = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter rank: ");
          rank = Console.ReadLine();
        }

        public void DisplayTroops()
        {
            Console.WriteLine("ID of the personnel: " + perID);
            Console.WriteLine("Name of the personnel: " + perName);
            Console.WriteLine("Date Of Birth: " + DOB);
            Console.WriteLine("Rank: " + rank);
        }
    }
}
