using System;

public class SavingAccount : Account
{
    public SavingAccount(string holderName, double balance) : base(holderName, balance)
    {
    }

    
    public override void Withdraw(double amount)
    {
        double fee = 10;
        double total = amount + fee;

        if (total > Balance)
        {
            Console.WriteLine("Not enough balance (including Rs.10 fee)!");
        }
        else
        {
            Balance -= total;
            Console.WriteLine($"Withdrawn: {amount}, Fee: {fee}");
        }
        ShowDetails();
    }
}
