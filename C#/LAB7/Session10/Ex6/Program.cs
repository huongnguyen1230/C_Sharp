using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    public class SpareParts
    {
        string _spareName;
        public SpareParts()
        {
            _spareName = "Gear Box";
        }
        public void Display()
        {
            Console.WriteLine("SparePart name: " + _spareName);
        }
    }
}
