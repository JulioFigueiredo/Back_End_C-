using System;

public class Bank
{
    public string Name { get; set; }
    public double Balance { get; private set; }

    public int Agency { get; set; }

    public Bank(string name, int agency)
    {
        Name=name;
        Agency=agency;
    }

    public void deposit(int amount) 
    {
        Balance=this.Balance+amount;
    }

    public void withdraw(int amount)
    {
        Balance = this.Balance-amount;
    }



}