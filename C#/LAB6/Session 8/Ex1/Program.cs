using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        public abstract void AnimalSound();
        public abstract void Habitat();
    }
}
