namespace L4_b;
class Program
{
    static void Main(string[] args)
    {
        PrintClass obj = new PrintClass();
        
        Console.Write("Enter something: ");
        string user_input = Console.ReadLine();
        
        obj.PrintFunc(user_input);
        
    }
}
