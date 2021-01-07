using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{

    //the program demonstrates the creation and use of sealed class
    //Class appraisal calculates the bonus of the employee depending
    //on the designation, tenure and salary 
    public sealed class Appraisal
    {
        //double field to store the bonus
        private double _bonus;

        //method to calculate the bonus
        public double CalculateBonus (string designation, int tenure, double salary )
        {
            if(designation == "Manager")
            {
                if(tenure <=5)
                {
                    _bonus = salary * 1.5;
                }
                else
                {
                    _bonus = salary * 2;
                }
            }

            if(designation == "Engineer")
            {
                if (tenure <=5)
                {
                    _bonus = salary;
                }
                else
                {
                    _bonus = salary * 2;
                }
            }
            return _bonus;
        }
    }
}
