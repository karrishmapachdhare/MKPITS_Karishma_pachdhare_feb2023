using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedclassemployee
{
    sealed class employee
    {
        public void showdata()
        {
            Console.WriteLine("hello");
        }
    }
        internal class program
        {
            static void main(string[] args)
            {
                employee emp = new employee();
                emp.showdata();
            }
        }
       
     
}
