namespace L4_e;
public class SquareClass
{   
    public int side;
    public void CalculateArea()
    {
        int area = side * side;
        Console.WriteLine("The area of the square is " + area);
    }
    public void CalculatePeri()
    {
        int peri = 4 * side;
        Console.WriteLine("The perimeter of the square is " + peri);
    }

}