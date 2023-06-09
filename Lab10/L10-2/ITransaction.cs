﻿namespace L10_2;

public interface ITransaction
{
    void ShowTransaction();
    double GetAmount();
}

public class Transaction : ITransaction
{
    private string tCode;
    private string date;
    private double amount;

    public Transaction()
    {
        tCode = " ";
        date = " ";
        amount = 0.0;
    }

    public Transaction(string c, string d, double a)
    {
        tCode = c;
        date = d;
        amount = a;
    }

    public double GetAmount()
    {
        return amount;
    }

    public void ShowTransaction()
    {
        Console.WriteLine("Transaction: {0}", tCode);
        Console.WriteLine("Date: {0}", date);
        Console.WriteLine("Amount: {0}", GetAmount());
    }
}