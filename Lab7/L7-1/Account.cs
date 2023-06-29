namespace L7_1;
public class Account
{
    protected double balance;

    public void Credit(double amount)
    {
        balance += amount;
    }

    public void Debit(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Debit amount exceeded account balance.");
        }
        else
        {
            balance -= amount;
        }
    }

    public double GetBalance()
    {
        return balance;
    }
}

class SavingsAccount : Account
{
    private double interestRate = 0.3;

    public double CalculateInterest()
    {
        return GetBalance() * interestRate;
    }

    public void UpdateBalance()
    {
        Credit(CalculateInterest());
    }
}

class CheckingAccount : Account
{
    private double fee = 0.2;

    public void Credit(double amount)
    {
        base.Credit(amount);
    }

    public void Debit(double amount)
    {
        if (amount > GetBalance())
        {
            Console.WriteLine("Debit amount exceeded account balance.");
        }
        else
        {
            balance -= amount;

            if (amount > 0)
            {
                base.Debit(fee);
            }
        }
    }
}