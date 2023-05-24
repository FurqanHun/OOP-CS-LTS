namespace _3_a;
class Program
{
    static void Main(string[] args)
    {
        int number;
        int result;
        System.Console.WriteLine("Enter a number to calculate the table");
        number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            result = number * i;
            System.Console.WriteLine("{0} * {1} = {2}", number, i, result);
        }
    }
}