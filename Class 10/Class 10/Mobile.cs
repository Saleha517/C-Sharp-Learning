using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10
{
    internal class Mobile
    {
        public string name;
        public string price;
        public string status;

        public void Function()
        {
            Console.WriteLine($"The mobile name is : {name} , The mobile price is {price} , The mobile status is {status}");
        }

    }
    class Sumsung : Mobile
    {
        public void sumsung()
        {
            Console.WriteLine($"This is child class The mobile name is : {name} , The mobile price is {price} , The mobile status is {status}");
        }

    }
}
