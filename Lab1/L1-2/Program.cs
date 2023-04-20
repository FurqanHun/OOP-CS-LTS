namespace L1_2;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The sum of the two numbers is: " + (num1 + num2));
        Console.WriteLine("The product of the two numbers is: " + (num1 * num2));
        Console.WriteLine("The difference of the two numbers is: " + (num1 - num2));
        Console.WriteLine("The quotient of the two numbers is: " + (num1 / num2));

    }
}
