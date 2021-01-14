using System;
using System.Collections;
    class SortedCollection
    {
        static void Main(string[] args)
        {
        SortedList objSL = new SortedList();
        objSL.Add("john", "administration");
        objSL.Add("jack", "human resources");
        objSL.Add("peter", "finance");
        objSL.Add("joel", "marketing");
        Console.WriteLine("Key\t\t Values");

        for(int i = 0; i < objSL.Count; i++)
        {
            Console.WriteLine(objSL.GetKey(i) + "\t\t" + objSL.GetByIndex(i));
        }
        if(!objSL.ContainsKey("jerry"))
        {
            objSL.Add("jerry", "construction");
        }
        objSL["peter"] = "engineering";
        objSL["jerry"] = "IT";
        Console.WriteLine();
        Console.WriteLine("update values stored in hash table");
        Console.WriteLine("key \t\t values");

        for(int i = 0; i < objSL.Count; i++)
        {
            Console.WriteLine(objSL.GetKey(i) + "\t\t" + objSL.GetByIndex(i));
        }
    }
    }
