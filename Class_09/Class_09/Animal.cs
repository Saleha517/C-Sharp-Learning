using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_09
{
    internal class Animal
    {

        public string name = "Dog";
        public string biological_name = "abc";
        public int price = 400;
        public string color = "Brown and Black";
        public void CatData()
        {
            Console.WriteLine("This is the parent class");
        }
    }

    class Cat:Animal
    {

        public string name;
        public string bg;
        public int price;
        public string color;
        public void Fun()
        {
            Console.WriteLine($"Animal Name is {name}, Animal's Biological Name is {bg}, Animal's Price is {price}, Animal Color is {color}");
        }
    }
}
