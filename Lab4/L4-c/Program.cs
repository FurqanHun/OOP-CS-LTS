namespace L4_c;
class Program
{
    static void PrintOddNumbers()
    {
        for (int i = 1; i < 20; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void Main(string[] args)
    {
        PrintOddNumbers();
    }
}