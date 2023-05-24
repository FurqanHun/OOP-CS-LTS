namespace L4_f;
class Program
{
    static void Main(string[] args)
    {   
        SquareClass obj = new SquareClass();

        Console.Write("Enter the side of the square: ");
        
        int s = int.Parse(Console.ReadLine());
        
        obj.CalculateArea(s);
        obj.CalculatePeri(s);
    }
}
