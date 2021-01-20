using System;
using System.Collections.Generic;

namespace Ex3
{
    static class ExtensionExample
    {
        public static List<T> RemoveDuplicate<T>(this List<T> allCities)
        {
            List<T> finalCities = new List<T>();
            foreach (var eachCity in allCities)
                if (!finalCities.Contains(eachCity))
                    finalCities.Add(eachCity);
            return finalCities;
        }
    }
    class Program
    {
     static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Berlin ");
            cities.Add("Istanbul");
            cities.Add("Istanbul");
            cities.Add("Paris");

            List<string> result = cities.RemoveDuplicate();
            foreach (string city in result)
                Console.WriteLine(city);
        }
     }
}
