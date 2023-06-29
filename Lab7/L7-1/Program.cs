namespace L7_1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Which account do you want to create? \n(1) Savings Account \n(2) Checking Account");
        int choice = int.Parse(System.Console.ReadLine());
        if (choice == 1)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            System.Console.WriteLine("Enter the amount to deposit: ");
            double amount = double.Parse(System.Console.ReadLine());
            savingsAccount.Credit(amount);
            System.Console.WriteLine("Enter the amount to withdraw: ");
            double withdrawAmount = double.Parse(System.Console.ReadLine());
            savingsAccount.Debit(withdrawAmount);
            savingsAccount.UpdateBalance();
            System.Console.WriteLine("The interest earned is: " + savingsAccount.CalculateInterest());
            System.Console.WriteLine("The balance is: " + savingsAccount.GetBalance());
        }
        else if (choice == 2)
        {
            CheckingAccount checkingAccount = new CheckingAccount();
            System.Console.WriteLine("Enter the amount to deposit: ");
            double amount = double.Parse(System.Console.ReadLine());
            checkingAccount.Credit(amount);
            System.Console.WriteLine("Enter the amount to withdraw: ");
            double withdrawAmount = double.Parse(System.Console.ReadLine());
            checkingAccount.Debit(withdrawAmount);
            System.Console.WriteLine("The balance is: " + checkingAccount.GetBalance());
        }
        else
        {
            System.Console.WriteLine("Invalid choice!");
        }
    }
}