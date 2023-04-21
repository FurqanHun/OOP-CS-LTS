namespace _2_a;
class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number");
        number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}
