using System;
using System.Collections;

    class ArrayCollection
    {
        static void Main(string[] args)
        {
        ArrayList objArray = new ArrayList();

        objArray.Add("James");
        objArray.Add("John");
        objArray.Add("Peter");
        objArray.RemoveAt(2);
        objArray.Insert(2, "Williams");
        Console.WriteLine("Capacity: " + objArray.Capacity);
        Console.WriteLine("Count: " + objArray.Count);
        Console.WriteLine();
        Console.WriteLine("ELements of the array list");
        foreach(string str in objArray)
        {
            Console.WriteLine(str);
        }
        }
    }

