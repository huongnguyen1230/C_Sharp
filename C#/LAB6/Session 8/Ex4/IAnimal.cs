using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    interface IAnimal
    {
        void Habitat();
    }
    class Dog: IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }
        static void Main(string[] argd)
        {
            Dog objDog = new Dog();
            Console.WriteLine(objDog.GetType().Name);
            objDog.Habitat();
        }
    }
}
