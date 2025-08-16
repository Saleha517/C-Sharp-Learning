using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Mymethod()
        {
            Console.WriteLine("This is Mymethod ");
        }

        static void Display(int a , int b)
        {
            Console.WriteLine($" a value is{a} , b value is {b}");
        }

        static void Data()
        {
            Console.WriteLine("This method have no parameter");
        }

        static void Data(string d1 = "Not Found" , string d2 = "Not Found")
        {
            Console.WriteLine($"{d1},{d2} \t This method have parameters");
        }

        static void Data(int s , int d)
        {
            Console.WriteLine("Data Method");
        }

        
        static void Main(string[] args)
        {
            Mymethod();
            Display(20, 31);
            Data();
            Data("Saleha" , "Manahil");
            Data(1, 2);

        }
    }
}
