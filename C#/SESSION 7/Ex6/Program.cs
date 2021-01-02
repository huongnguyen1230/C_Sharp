using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
        public Animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }
    }
    class Cannie : Animal
    {
        //base() takes a string value called "Lion"
        public Cannie() : base("Lion")
        {
            Console.WriteLine("Derived Cannie");
        }
    }
    class Details
    {
        static void Main(string[] args)
        {
            Cannie objCannie = new Cannie();
        }
    }
}

