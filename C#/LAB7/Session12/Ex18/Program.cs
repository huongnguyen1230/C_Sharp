using System;
using System.Collections.Generic;
using System.Collections;
    class Car
    {
        static void Main(string[] args)
        {
        Dictionary<int, string> objD = new Dictionary<int, string>();
        objD.Add(201, "Hard Disk");
        objD.Add(220, "Oil Filter");
        objD.Add(330, "Engine");
        objD.Add(305, "Raditor");
        objD.Add(303, "Steering");
        Console.WriteLine("Dictionary class contains values of type");
        Console.WriteLine(objD.GetType());
        Console.WriteLine("Key\t\tValues");
        Console.WriteLine("-----------------------");

        IDictionaryEnumerator objDE = objD.GetEnumerator();
        while(objDE.MoveNext())
        {
            Console.WriteLine(objDE.Key.ToString() + "\t\t" + objDE.Value);
        }
    }
    }

