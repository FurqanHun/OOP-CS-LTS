namespace oopA3;

class Program
{
    static void Main(string[] args)
    {
        Bank_Account account1 = new Bank_Account();
        account1.accountNumber = "123";
        account1.accountType = "Current";

        System.Console.WriteLine("Enter Name of Depositor: ");
        account1.nameOfDepositor = System.Console.ReadLine();

        System.Console.WriteLine("Enter Amount to Deposit: ");
        int money = int.Parse(System.Console.ReadLine());
        account1.Deposit_Amount(money);

        System.Console.WriteLine("Enter Amount to Withdraw: ");
        money = int.Parse(System.Console.ReadLine());
        account1.Withdraw_Amount(money);

        account1.Display_Balance();
    }
}
