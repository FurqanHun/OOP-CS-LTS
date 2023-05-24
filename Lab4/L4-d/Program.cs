namespace L4_d;
class Program
{
    static void Main(string[] args)
    {
        EvenOddClass obj = new EvenOddClass();

        Console.Write("Enter a number: ");
        
        int num = int.Parse(Console.ReadLine());
        obj.CheckEvOdd(num);
    }
}
