using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompany
{
    class System

    {
        const string Console = "Console";
        public static string WriteLine()
        {
            return "WriteLine method of my System class";
        }
        static void Main(string[] args)
        {
            global::System.Console.WriteLine(WriteLine());
        }
    }
}
