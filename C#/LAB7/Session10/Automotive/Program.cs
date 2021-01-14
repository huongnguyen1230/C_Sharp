using Automotive.Vehicle.Jeep;
using System;
using System.Collections.Generic;
using System.Text;
using Utility_Vehicle = Automotive.Vehicle.Jeep;

namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category
            {
                string _category;
                public Category()
                {
                    _category = "Multi Utility Vehicle";
                }
                public void Display()
                {
                    Console.WriteLine("Jeep Category" + _category);
                }
            }
        }
            class Automobile
            {
                static void Main(string[] args)
                {
                Category obj = new Category();
                obj.Display();
                Utility_Vehicle.Car.Category objC = new Utility_Vehicle.Car.Category();
                objC.Display();
                }
            }
    }
    
}
