namespace _3_d;
class Program
{
    static void Main(string[] args)
    {
       int i = 2;
         int sum = 0;
            do
            {
                sum += i;
                i += 3;
            } while (i < 100);
            Console.WriteLine(sum);
    }
}
