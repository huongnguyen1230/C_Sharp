using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class studentDetails
    {
        string _studName = "Alexander";
        int _stuID = 30;
        public studentDetails()
        {
            Console.WriteLine("Student Name: " + _studName);
            Console.WriteLine("Student ID: " + _stuID);
        }
    }
    namespace Examination
    {
        class ScoreReport
        {
            public string Subject = "Science";
            public int Marks = 60;
            static void Main(string[] args)
            {
                Ex11.studentDetails obj = new Ex11.studentDetails();
                ScoreReport objR = new ScoreReport();
                Console.WriteLine("Subject: " + objR.Subject);
                Console.WriteLine("Marks: " + objR.Marks);
            }
        }
    }
}
