using System;
public delegate void Maths(int valOne, int valTwo);


    class MathsDemo
    {
    static void Addition(int valOne, int valTwo)
    {
        int result= valOne + valTwo;
        Console.WriteLine("Addition: " + valOne + "+" + valTwo + "=" + result);
    }
    static void Subtraction(int valOne, int valTwo)
    {
        int result = valOne - valTwo;
        Console.WriteLine("Subtraction: " + valOne + "-" + valTwo + "=" + result);
    }
    static void Multiplication(int valOne, int valTwo)
    {
        int result = valOne * valTwo;
        Console.WriteLine("Multiplication: " + valOne + "*" + valTwo + "=" + result);
    }
    static void Division(int valOne, int valTwo)
    {
        int result = valOne / valTwo;
        Console.WriteLine("Division: " + valOne + "/" + valTwo + "=" + result);
    }

    static void Main(string[] args)
        {
        Maths obj = new Maths(Addition);
        obj += new Maths(Subtraction);
        obj += new Maths(Multiplication);
        obj += new Maths(Division);
        if(obj != null)
        {
            obj(20, 10);
        }
        }
    }

