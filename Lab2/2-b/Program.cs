namespace _2_b;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        switch (age)
        {
            case > 45:
                Console.WriteLine("You are old stay at home and wait for call");
                break;

            case < 30:
                Console.WriteLine("Hey! Man enjoy your life with your kids");
                break;

            default:
                Console.WriteLine("You are in the middle of your life");
                break;
        }
    }

}
