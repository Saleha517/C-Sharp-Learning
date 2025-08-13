using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Username");
            string user = Console.ReadLine();

            Console.WriteLine("Enter Your Password");
            string pass = Console.ReadLine();

            string admin = user == "saleha" && pass == 123 ? "Login successfully" : "invalid user or pass";

            Console.WriteLine(admin);





            Console.WriteLine("----\"Calculator\"-------");

            Console.WriteLine("Enter First Number");
            int digit1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int digit2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Any Operator (+ , - , * , / )");
            string opt = Console.ReadLine();

            string output = Console.ReadLine();

            string result = "";

             switch (opt)
            {
                case "+":

                    result = $"{digit1 - digit2}";

                    break;

                case "-":

                    result = $"{digit1 - digit2}";

                    break;

                case "*":

                    result = $"{digit1 * digit2}";

                    break;

                case "/":

                    result = $"{digit1 / digit2}";

                    break;

                default:
                    result = $"{"Invalid Data Inserted"}";

                    break;

                    
              
            }

            Console.WriteLine($"Your Result is : {result}");

            Console.ReadKey();
        }
    }
}
