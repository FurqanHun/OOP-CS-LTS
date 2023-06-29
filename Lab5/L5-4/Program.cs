namespace L5_4;

class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        System.Console.WriteLine("Enter Length and Width of Rectangle");
        r.Length = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter Width of Rectangle");
        r.Width = Convert.ToInt32(Console.ReadLine());
        r.CalculateArea();
        r.CalculatePerimiter();
        r.IsSquare();
        Console.WriteLine("Area of Rectangle is {0}", r.Area);
        Console.WriteLine("Perimiter of Rectangle is {0}", r.Perimiter);
        Console.WriteLine("Is Rectangle a Square? {0}", r.IsSquare());
    }
}
