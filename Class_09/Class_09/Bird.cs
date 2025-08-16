using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_09
{
    internal class Bird
    {
        protected string name = "Sparrow";
        protected int price = 600;
        protected string color = "Brown and Black";

        public void Result()
        {
         
         Console.WriteLine($"Bird Name is {name} , Bird Price is {price} , Bird Color is {color} ");
        }

    }
}
