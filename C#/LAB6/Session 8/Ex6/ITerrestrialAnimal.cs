using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    interface ITerrestrialAnimal
    {
        void Eat();
    }
    interface IMarineAnimal
    {
        void Swim();
    }
    class Crocodile: ITerrestrialAnimal, IMarineAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The crocodile eats flesh");

        }
        public void Swim()
        {
            Console.WriteLine("The crocodile can swim four times faster than an Olympic swimmer");
        }
    }
}
