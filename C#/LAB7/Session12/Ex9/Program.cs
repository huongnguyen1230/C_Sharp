using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


    class Employee:DictionaryBase
    {
    public void Add(int id, string name)
    {
        Dictionary.Add(id, name);
    }
    public void OnRemove(int id)
    {
        Console.WriteLine("You're going to delete record containing ID: " + id);
        Dictionary.Remove(id);
    }
    public void GetDetails()
    {
        IDictionaryEnumerator obj = Dictionary.GetEnumerator();
        while(obj.MoveNext())
        {
            Console.WriteLine(obj.Key.ToString() + "\t\t" + obj.Value);
        }
    }
        static void Main(string[] args)
        {
        Employee objE = new Employee();
        objE.Add(102, "John");
        objE.Add(103, "James");
        objE.Add(106, "Peter");
        Console.WriteLine("Orignal values stored in Dictionary");
        objE.GetDetails();
        objE.OnRemove(106);
        }
    }

