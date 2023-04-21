namespace L1_1a;
class Program
{
    static void Main(string[] args)
    {
       string? firstNumber, secondNumber; 
        int number1, number2, sum; 
        
        Console.Write("Please enter the first integer: ");
        firstNumber = Console.ReadLine();
        
        Console.Write("\nPlease enter the second integer: ");
        secondNumber = Console.ReadLine();
        
        number1 = Int32.Parse(firstNumber ?? "0");
        number2 = Int32.Parse(secondNumber ?? "0");
        sum = number1 + number2;

        Console.WriteLine( "\nThe sum is {0}.", sum );
    }
}
