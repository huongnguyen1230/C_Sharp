using System;
using System.Collections;
using System.Collections.Generic;


    class DictionaryCollection
    {
        static void Main(string[] args)
        {
        Dictionary<int, string> objD = new Dictionary<int, string>();
        objD.Add(25, "Hard Disk");
        objD.Add(30, "Mary");
        objD.Add(15, "William");
        objD.Add(65, "Rodrick");
        ICollection objC = objD.Keys;
        Console.WriteLine("Orignal values stored in the collection");
        Console.WriteLine("Key \tValues");
        Console.WriteLine("----------------");

        foreach(int i in objC)
        {
            Console.WriteLine(i + "\t" + objD[i]);
        }
        objD.Remove(65);
        Console.WriteLine();
        if(objD.ContainsValue("Memory"))
        {
            Console.WriteLine("Value Memory could not be deleted");
        }
        else
        {
            Console.WriteLine("value memory deleted successfully");
        }
        Console.WriteLine();
        Console.WriteLine("values stored after removing element");
        Console.WriteLine("Key \tValues");
        Console.WriteLine("--------------------");

        foreach(int i in objC)
        {
            Console.WriteLine(i + "\t" + objD[i]);
        }
    }
    }

