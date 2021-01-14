using System;
using System.Collections;
    class HashCollection
    {
        static void Main(string[] args)
        {
        Hashtable objTable = new Hashtable();

        objTable.Add(001, "John");
        objTable.Add(002, "Peter");
        objTable.Add(003, "James");
        objTable.Add(004, "Joe");
        Console.WriteLine("number of elements in the hash table: " + objTable.Count);
        ICollection objCo = objTable.Keys;
        Console.WriteLine("orignal values stored in hashtable are: ");
        foreach(int i in objCo)
        {
            Console.WriteLine(i + ":" + objTable[i]);
        }
        if(objTable.ContainsKey(002))
        {
            objTable[002] = "partrick";
        }
        Console.WriteLine("values stored in the hash table after removing values");
        foreach(int i in objCo)
        {
            Console.WriteLine(i + ":" + objTable[i]);
        }
        }
    }

