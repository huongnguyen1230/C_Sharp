using System;
using Students;
namespace Students
{
    class StudentDetails
    {
        string _studName = "Alexander";
        int _stuID = 30;
        public StudentDetails()
        {
            Console.WriteLine("Student Name: " + _studName);
            Console.WriteLine("Student ID: " + _stuID);
        }
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
            StudentDetails obj = new StudentDetails();
            ScoreReport objReport = new ScoreReport();
            Console.WriteLine("Subject: " + objReport.Subject);
            Console.WriteLine("Marks: " + objReport.Marks);
        }
    }
}
