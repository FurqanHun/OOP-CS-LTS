namespace L5_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter interest rate: ");
        double interestRate = Convert.ToDouble(Console.ReadLine());

        BankAccount account = new BankAccount(balance, interestRate);
        if (account.GetBalance() < 0)
        {
            Console.WriteLine("Balance cannot be negative");
            return;
        }
        if (account.GetInterestRate() < 0)
        {
            Console.WriteLine("Interest rate cannot be negative");
            return;
        }
        Console.WriteLine("Press 1 to deposit, \n2 to withdraw, \n3 to set interest rate,\n4 to add interest, \n5 to get balance, \n6 to get interest, \n7 to get interest rate, \n8 to exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice != 8)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter amount to deposit: ");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(deposit);
                    break;
                case 2:
                    Console.WriteLine("Enter amount to withdraw: ");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;
                case 3:
                    Console.WriteLine("Enter interest rate: ");
                    double interest = Convert.ToDouble(Console.ReadLine());
                    account.SetInterestRate(interest);
                    break;
                case 4:
                    account.AddInterest();
                    break;
                case 5:
                    Console.WriteLine("Balance: " + account.GetBalance());
                    break;
                case 6:
                    Console.WriteLine("Interest: " + account.GetInterest());
                    break;
                case 7:
                    Console.WriteLine("Interest Rate: " + account.GetInterestRate());
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine("Press 1 to deposit, \n2 to withdraw, \n3 to set interest rate,\n4 to add interest, \n5 to get balance, \n6 to get interest, \n7 to get interest rate, \n8 to exit");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
