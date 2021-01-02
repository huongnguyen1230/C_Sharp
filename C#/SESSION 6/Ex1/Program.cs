using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        string _bookName;
        public string Print()
        {
            return _bookName;
        }
        public void Input(string bkName)
        {
            _bookName = bkName;
        }
        static void Main(string[] args)
        {
            Program objBook = new Program();
            objBook.Input("C#-The Complete Reference");
            Console.WriteLine(objBook.Print());
        }
    }
}
