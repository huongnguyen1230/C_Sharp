using System;
using System.Collections;
    class Authors
    {
        static void Main(string[] args) 
        {
        Hashtable objA = new Hashtable();
        objA.Add("AU01", "John");
        objA.Add("AU04", "Mary");
        objA.Add("AU07", "William");
        objA.Add("AU06", "Rodrick");
        Console.WriteLine("Read-only: " + objA.IsReadOnly);
        Console.WriteLine("Count: " + objA.Count);
        IDictionaryEnumerator objCol = objA.GetEnumerator();
        Console.WriteLine("List of authors: \n");
        Console.WriteLine("Author ID: \t Name");
        while(objCol.MoveNext())
        {
            Console.WriteLine(objCol.Key + "\t\t" + objCol.Value);
        }
        if(objA.Contains("AU01"))
        {
            Console.WriteLine("\nList contains author with id AU01");
        }
        else
        {
            Console.WriteLine("\nList does not contain author with id AU01");
        }
    }
    }
