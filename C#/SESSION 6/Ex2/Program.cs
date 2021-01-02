using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        void printName(String firstName, string lastName)
        {
            Console.WriteLine("First Name = {0}, Last Name = {1}", firstName, lastName);
        }
        static void Main(string[] args)
        {
            Program student = new Program();
            /* passing argument by position */
            student.printName("Herry", "Parker");
            //Passing named argument
            student.printName(firstName: "Herry", lastName: "Parker");
            student.printName(lastName: "Parker", firstName: "Herry");
            //passing named argument after positional argument
            student.printName("Herry", lastName: "Parker");
        }
    }
}
