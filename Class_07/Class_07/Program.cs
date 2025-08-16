using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_07
{
    internal class Program
    {
         

        static void Main(string[] args)
        {
            Animal obj = new Animal();
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.price);
            Console.WriteLine(obj.Category);
            Console.WriteLine(obj.Biological_Name);

            Console.ReadKey();
        }
    }
}
