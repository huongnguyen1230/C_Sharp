using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    class Troops
    {
        public int ID;
        public string name;
        public string location;
        public int numGroup;

        public Troops()
        {

        }

        public Troops(int _ID, string _name, string _location, int _numGroup)
        {
            this.ID = _ID;
            this.name = _name;
            this.location = _location;
            this.numGroup = _numGroup;
        }

        public void CreateTroops()
        {
            Console.Write("Enter ID of the troop: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name of the troop: ");
            name = Console.ReadLine();

            Console.Write("Enter posted location: ");
            location = Console.ReadLine();

            Console.Write("Enter number of group: ");
            numGroup = Convert.ToInt32 (Console.ReadLine());
        }

        public void DisplayTroops()
        {
            Console.WriteLine("ID of the troop: " + ID);
            Console.WriteLine("Name of the troop " + name);
            Console.WriteLine("Posted Location: " + location);
            Console.WriteLine("Number of group: " + numGroup);
        }
    }
}
