namespace L4_g;
class Program
{
    static void Main(string[] args)
   {
        
        string choice;
        
        double num1;
        
        double num2;

        CalcFunc obj = new CalcFunc();

        do
        {
            
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power");
            Console.WriteLine("6. Square root");
            Console.WriteLine("7. Exit");

            
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    Console.Write("Enter the first number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = double.Parse(Console.ReadLine());
                    
                    obj.Add(num1, num2);
                    break;
                case "2":
                    
                    Console.Write("Enter the first number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = double.Parse(Console.ReadLine());
                    
                    obj.Subtract(num1, num2);
                    break;
                case "3":
                    
                    Console.Write("Enter the first number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = double.Parse(Console.ReadLine());
                    
                    obj.Multiply(num1, num2);
                    break;
                case "4":
                    
                    Console.Write("Enter the first number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    num2 = double.Parse(Console.ReadLine());
                    
                    obj.Divide(num1, num2);
                    break;
                case "5":
                    
                    Console.Write("Enter the base number: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the exponent number: ");
                    num2 = double.Parse(Console.ReadLine());
                    
                    obj.Power(num1, num2);
                    break;
                case "6":
                    
                    Console.Write("Enter a number: ");
                    num1 = double.Parse(Console.ReadLine());
                    
                    obj.Sqrt(num1);
                    break;
                case "7":
                    
                    break;
                default:
                    
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            
            Console.WriteLine();

        } while (choice != "7");  

    }
}
