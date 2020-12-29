﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        public static void Main()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                unchecked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
