﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classOne = { "Allan", "Chris", "Monica" };
            string[] classTwo = { "Katie", "Niel", "Mark" };
            Console.WriteLine("Students of Class I: \tStudent of Class II");
            for(int i = 0; i < 3; i ++)
            {
                Console.WriteLine(classOne[i] + "\t\t\t" + classTwo[i]);
            }
            classTwo = classOne;
            Console.WriteLine("\nStudents of Class II after referencing Class I:");
            for (int i = 0; i<3; i++)
            {
                Console.WriteLine(classTwo[i] + "");
            }
            Console.WriteLine();
            classTwo[2] = "Mike";
            Console.WriteLine("Students of Class I after changing the third student in Class II:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(classOne[i] + "");
            }
        }
    }
}
