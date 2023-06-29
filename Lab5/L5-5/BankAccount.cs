namespace L5_5;

public class BankAccount
{
    private double balance;
    private double interestRate;
    private double interest;
    public BankAccount(double balance, double interestRate)
    {
        this.balance = balance;
        this.interestRate = interestRate;
    }
    public void Deposit(double amount)
    {
        balance += amount;
    }
    public void Withdraw(double amount)
    {
        balance -= amount;
    }
    public void SetInterestRate(double interestRate)
    {
        this.interestRate = interestRate;
    }
    public void AddInterest()
    {
        interest = balance * interestRate;
        balance += interest;
    }
    public double GetBalance()
    {
        return balance;
    }
    public double GetInterest()
    {
        return interest;
    }
    public double GetInterestRate()
    {
        return interestRate;
    }
    
}
