
using System;
class Account
{

    private string accName;
    private string acid;
    private int balance;

    public Account(string accName, string acid, int balance)
    {
        this.accName = accName;
        this.acid = acid;
        this.balance = balance;
    }
    public Account() { }

    public string Name
    {
        get { return accName; }
        set { accName = value; }
    }

    public string ID
    {
        get { return acid; }
        set { acid = value; }
    }

    public int Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public void Deposit(int amount)
    {
        balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount <= balance)
            balance -= amount;
    }
    public void ShowAccountInfo()
    {
        Console.WriteLine("Account Name: " + accName);
        Console.WriteLine("Account ID: " + acid);
        Console.WriteLine("Account Balance: " + balance);
    }
}
