using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    interface IAnimal
    {
        void Drink();
    }
    interface InCarnivorous
    {
        void Eat();
    }
    interface IReptile: IAnimal, InCarnivorous
    {
        void Habitat();
    }
    class Crocodile: IReptile
    {
        public void Drink()
        {
            Console.WriteLine("Drinks fresh water");
        }
        public void Habitat()
        {
            Console.WriteLine("Can stay in Water and Land");
        }
        public void Eat()
        {
            Console.WriteLine("Eats Flesh");
        }
    
        static void Main(string[] args)
        {
            Crocodile obj = new Crocodile();
            Console.WriteLine(obj.GetType().Name);
            obj.Habitat();
            obj.Eat();
            obj.Drink();
        }
    }
    
}
