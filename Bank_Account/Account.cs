using System;

public class Account
{
    public string HolderName { get; set; }
    public double Balance { get; set; }

   
    public Account(string holderName, double balance)
    {
        HolderName = holderName;
        Balance = balance;
    }

   
    public virtual void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Not enough balance!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        ShowDetails();
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Holder Name: {HolderName}, Current Balance: {Balance}\n");
    }
}
