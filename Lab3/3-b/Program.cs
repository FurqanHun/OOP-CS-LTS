namespace _3_b;
class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number to make a pattern");
        number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}