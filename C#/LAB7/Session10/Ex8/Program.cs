
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace Ex8
{
    class Toyota
    {
        static void Main(string[] args)
        {
            Category obj = new Category();
            SpareParts objSpare = new SpareParts();
            obj.Display();
            objSpare.Display();
        }
    }
}
