using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10
{
    internal class Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Animals makes sound");
        }
    }

    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Dog Barks");
        }
    }

    class Cat : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Cat Meaows");
        }
    }
}
