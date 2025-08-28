using System;

public class CurrentAccount : Account
{
    public CurrentAccount(string holderName, double balance) : base(holderName, balance)
    {
    }

    
    public override void Withdraw(double amount)
    {
        base.Withdraw(amount); 
    }
}
