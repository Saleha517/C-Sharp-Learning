using System;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Current Account");
            Console.WriteLine("2. Saving Account");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 3)
            {
                Console.WriteLine("Exiting program... Goodbye!");
                break;
            }

            Account acc;

            if (choice == 1)
            {
                acc = new CurrentAccount(name, balance);
                Console.WriteLine("\nCurrent Account Selected!");
            }
            else if (choice == 2)
            {
                acc = new SavingAccount(name, balance);
                Console.WriteLine("\nSaving Account Selected!");
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again.");
                continue;
            }

            acc.ShowDetails();

            Console.Write("Enter amount to withdraw: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            acc.Withdraw(withdrawAmount);

            
            balance = acc.Balance;
        }
    }
}
