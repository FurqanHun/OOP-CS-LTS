namespace L6_2;
class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int fact = Factorial.CalculateFactorial(number);
        Console.WriteLine("Factorial of {0} is {1}", number, fact);
    }
}
