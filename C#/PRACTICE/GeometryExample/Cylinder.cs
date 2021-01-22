using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    class Cylinder
    {
        double radius;
        double height;
        double BaseArea;
        double LateralArea;
        double TotalArea;
        double Volume;
        public void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder: ");
            Console.WriteLine("Height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            BaseArea = radius * radius * Math.PI; 
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }
       public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Height: " + height);
           
            
            Console.WriteLine("Base: " + BaseArea);

           
            Console.WriteLine("Lateral: " + LateralArea);

           
            Console.WriteLine("Total: " + TotalArea);

          
            Console.WriteLine("Volume: " + Volume);
        }
    }
}
      

