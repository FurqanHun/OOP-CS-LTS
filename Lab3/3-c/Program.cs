namespace _3_c;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int i = 0;
        do
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            sum += num;
            i++;
        } while (i < 4);
        Console.WriteLine("Sum of four numbers is " + sum);
    }
}
