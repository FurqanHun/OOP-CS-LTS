namespace oopA3;

public class Bank_Account
{
    public string accountNumber { get; set; }
    public string nameOfDepositor { get; set; }
    public string accountType { get; set; }
    public int balance { get; set; }

    public void Deposit_Amount(){
        System.Console.WriteLine("yo what add some money");

    }
    public void Withdraw_Amount(){
        System.Console.WriteLine("nahh dont do that");

    }
    public void Display_Balance(){
        System.Console.WriteLine("Account Number: " + accountNumber);
        System.Console.WriteLine("Account Type: " + accountType);
        System.Console.WriteLine("Name of Depositor: " + nameOfDepositor);
        System.Console.WriteLine("Balance: " + balance);
    }

    public void Deposit_Amount(int money){
    balance += money;
}

    public void Withdraw_Amount(int money){
    if (money > balance)
    {
        System.Console.WriteLine("Insufficient Balance");
        return;
    }
    balance -= money;
}
}
