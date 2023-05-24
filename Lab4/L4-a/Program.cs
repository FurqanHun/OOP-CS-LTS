namespace L4_a;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        PrintString printer = new PrintString(name);
        printer.print();
       
    }
}
