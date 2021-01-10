using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    interface IMath
    {
        void Area();
    }
    class Circle: IMath
    {
        public const float PI = 3.14F;
        protected float radius;
        protected double AreaOfCircle;
        public virtual void Area()
        {
            AreaOfCircle = (PI * radius * radius);
        }
    }
    class Sphere: Circle
    {
        double _areaOfSphere;
        public override void Area()
        {
            base.Area();
            _areaOfSphere = (AreaOfCircle * 4);
        }
        static void Main(string[] args)
        {
            Sphere obj = new Sphere();
            obj.radius = 7;
            obj.Area();
            Console.WriteLine("Area of Sphere: {0:F2}",
                obj._areaOfSphere);
        }
    }
}
