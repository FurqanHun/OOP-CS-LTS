namespace Lb_3;
class Program
{
    static void Main(string[] args)
    {
        int current_balance = 10000;
        int withdraw_amount = 0;
        
        Console.WriteLine("Enter the amount to withdraw: ");
        withdraw_amount = Convert.ToInt32(Console.ReadLine());
        if(withdraw_amount > current_balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            Console.WriteLine("Amount is available!");
        }
    }
}
