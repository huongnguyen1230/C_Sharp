﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -5;
            if (num <0  || num > 10)
            {
                Console.WriteLine("the number exists between 1 and 10");
            }
            else
            {
                Console.WriteLine("the number does not exist between 1 and 10");
            }
        }
    }
}
