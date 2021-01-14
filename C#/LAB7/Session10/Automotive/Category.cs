using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    namespace Utility_Vehicle
    {
        namespace Car
        {
         class Category
            {
                string _category;
                public Category()
                {
                    _category = "Luxury Vehicle";
                }
                public void Display()
                {
                    Console.WriteLine("Car Category: " + _category);
                }
            }
        }
    }
   
}
