using System;
using System.Collections;
namespace Ex2
{
    class Customer 
    {
        static void Main(string[] args)
        {
            ArrayList objCus = new ArrayList();
            objCus.Add("Nicole Anderson");
            objCus.Add("Ashley Thomas");
            objCus.Add("Garry White ");
            Console.WriteLine("Fixed Size: " + objCus.IsFixedSize);
            Console.WriteLine("Count: " + objCus.Count);
            Console.WriteLine("List of customers: ");
            foreach(string names in objCus)
            {
                Console.WriteLine("{0}", names);
            }

            objCus.Sort();
            Console.WriteLine("\nList of customers after sorting: ");
            foreach(string names in objCus)
            {
                Console.WriteLine("{0}", names);
            }
            objCus.Clear();
            Console.WriteLine("Count after removing all elements: " + objCus.Count);
        }
    }
}
