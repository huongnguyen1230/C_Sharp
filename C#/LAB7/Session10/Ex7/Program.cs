using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//the autotive namespace contains the class Category and this namespace is partly stored in the Category.csfile
namespace Ex7
{
    public class Category
    {
        string _category;
        public Category()
        {
            _category = "abc";
        }
        public void Display()
        {
            Console.WriteLine("Category:" + _category);
        }
    }
}
