namespace L4_e;
class Program
{
    static void Main(string[] args)
    {   
        SquareClass obj = new SquareClass();
        obj.side = 9;
        obj.CalculateArea();
        obj.CalculatePeri();
    }

}
