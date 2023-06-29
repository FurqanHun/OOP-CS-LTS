namespace L6_5;

class Program
{
    static void Main(string[] args)
    {   
        System.Console.Write("Enter first number: ");
        int a = int.Parse(System.Console.ReadLine());
        System.Console.Write("Enter second number: ");
        int b = int.Parse(System.Console.ReadLine());
        Calculation calc = new Calculation(a,b);

        System.Console.WriteLine("Enter 1 for Addition and 2 for Subtraction: ");
        int choice = int.Parse(System.Console.ReadLine());
        if (choice == 1)
            calc.Add();
        else if (choice == 2)
            calc.Subtract();
        else
            System.Console.WriteLine("Invalid choice");
    }
}