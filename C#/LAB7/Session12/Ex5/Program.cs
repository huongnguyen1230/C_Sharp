using System;
public delegate void Messager(int value);

    class CompositeDelegates
    {   \
    static void EvenNumber(int value)
        {
        Console.Write("Even Numbers: ");
        for(int i = 2; i<= value; i+=2)
        {
            Console.Write(i + "");
        }
        }
    void oddNumbers(int value)
    {
        Console.WriteLine();
        Console.Write("Odd Numbers");
        for(int i = 1; i<= value; i+=2)
        {
            Console.Write(i + "");
        }
    }
    static void Start(int number)
    {
        CompositeDelegates objCom = new CompositeDelegates();
        Messager objDisplayOne = new Messager(EvenNumber);
        Messager objDisplayTwo = new Messager(objCom.oddNumbers);
        Messager objDisplayComposite = (Messager)Delegate.Combine(objDisplayOne, objDisplayTwo);
        objDisplayComposite(number);
        Console.WriteLine();

        Object obj = objDisplayComposite.Method.ToString();
        if(obj!=null)
        {
            Console.WriteLine("the delegate invokes an instance method" + obj);
        }
    }
        static void Main(string[] args)
        {
        int value = 0;
        Console.WriteLine("enter the values till which you want to display even and" +
            "odd numbers");
        try
        {
            value = Convert.ToInt32(Console.ReadLine());
        }
        catch(FormatException objFormat)
        {
            Console.WriteLine("Error: " + objFormat);
        }
        Start(value);
        }
    }

