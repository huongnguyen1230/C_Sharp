using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall
{
    class ElectronicStoreTest
    {
        ElectronicStore objStore = new ElectronicStore();
        bool Display()
        {
            Rebate objRebate = new Rebate(objStore.Discount);

            double total = objStore.ValueOfGoods();
            double value = objRebate(total);
            double netValue = total - value;

            Console.WriteLine();
            Console.WriteLine("product name: \t\t" + objStore.ItemName);
            Console.WriteLine("price per unit: \t" +objStore.ItemPrice);
            Console.WriteLine("number of units sold: \t" + objStore.Quantity);
            Console.WriteLine("total price: \t\t" + total);
            Console.WriteLine("discount rate: \t\t" + objStore.Rate + "%");
            Console.WriteLine("discount: \t\t" + value);
            Console.WriteLine("Net value: \t\t" + netValue);

            return true;
        }
        static void Main(string[] args)
        {
            ElectronicStoreTest objTest = new ElectronicStoreTest();
            Call objCall = new Call(objTest.objStore.ChooseProduct);

            if(objCall())
            {
                objCall -= new Call(objTest.objStore.ChooseProduct);
                objCall += new Call(objTest.Display);
                objCall();
            }
            else
            {
                return;
            }
        }
    }
}
