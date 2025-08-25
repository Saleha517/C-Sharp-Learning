using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---\"Polyorphism\"---\n");

            Animal animal = new Animal();
            animal.AnimalSound();

            Dog animal2 = new Dog();
            animal2.AnimalSound();

            Cat animal3 = new Cat();
            animal3.AnimalSound();


            Console.WriteLine("\n---\"Inheritance\"---\n");

            

            Sumsung mobile2 = new Sumsung();
            mobile2.name = "SumsungA30";
            mobile2.price = "15000";
            mobile2.status = "New";
            mobile2.Function();
            mobile2.sumsung();

        }
    }
}