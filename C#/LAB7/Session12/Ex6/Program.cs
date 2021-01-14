using System;
public delegate void PrintDetails();


    class TestEvent
    {
    event PrintDetails Print;
    void Show()
    {
        Console.WriteLine("This program illustrate how to subcribe objects to an event");
        Console.WriteLine("This is method will not execute since the event has not been raised");
    }
        static void Main(string[] args)
        {
        TestEvent objTE = new TestEvent();
        objTE.Print += new PrintDetails(objTE.Show);
        }
    }

