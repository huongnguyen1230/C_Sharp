using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animals1
    {
        float weight;
        string name;

        public void Show()
        {
            Console.WriteLine("Name:{0} \nWeight:{1}", name, weight);
        }

        public void SetMe( string _name,float _weight)
        {
            this.weight = _weight;
            this.name = _name;
        }
    }

   
}
