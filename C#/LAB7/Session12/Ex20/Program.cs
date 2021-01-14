using System;
using System.Collections.Generic;
using System.Collections;
class Employee
{
    public string Name { get; set; }
    public string Designation { get; set; }
}
class CollectionInitializerDemo
{ 
        static void Main(string[] args)
        {
        Dictionary<int, Employee> dict = new Dictionary<int, Employee>()
        {
            {1, new Employee{Name = "Andy Parker", Designation = "Sale Person"}},
            {2, new Employee{Name = "Partrick Elvis", Designation = "Marketing Manager"}}
        };
        }
    }

