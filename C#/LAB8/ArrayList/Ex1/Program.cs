using System;
using System.Collections;

namespace Ex1
{
    class ArrayCollection
    {
        static void Main(string[] args)
        {
            ArrayList objList = new ArrayList();
            objList.Add("John");
            objList.Add("James");
            objList.Add("Peter");
            objList.RemoveAt(2);
            objList.Insert(2, "Williams");

            Console.WriteLine("Capacity: " + objList.Capacity);
            Console.WriteLine("Count: " + objList.Count);
            Console.WriteLine();
            Console.WriteLine("Elements of the ArrayList");
            foreach(string str in objList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
