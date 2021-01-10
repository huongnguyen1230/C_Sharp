using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    interface ITerestrialAnimal1
    {
        string Eat();
    }
    interface IMarineAnimal
    {
        string Eat();
    }
    class Crocodile: ITerestrialAnimal1, IMarineAnimal
    {
        string ITerestrialAnimal1.Eat()
        {
            string terCroc = "Crocodile eats other animals";
            return terCroc;
        }
        string IMarineAnimal.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }
        public string EatTerrestrial()
        {
            ITerestrialAnimal1 obj;
            obj = this;
            return obj.Eat();
        }
        public string EatMarine()
        {
            IMarineAnimal obj;
            obj = this;
            return obj.Eat();
        }

    }
}
