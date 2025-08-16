using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object 

            Bird aboutbirds = new Bird();
            aboutbirds.Result();


            Animal animal = new Animal();

            Cat cat = new Cat();

            cat.name = "Tom";
            cat.bg = "Felus Catus";
            cat.price = 2000;
            cat.color = "Brown and Black";

            cat.Fun();

        }
    }
}
