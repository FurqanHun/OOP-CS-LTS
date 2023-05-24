namespace L4_f;
public class SquareClass
{
    public void CalculateArea(int side)
    {
        int area = side * side;
        Console.WriteLine("The area of the square is " + area);
    }
    public void CalculatePeri(int side)
    {
        int peri = 4 * side;
        Console.WriteLine("The perimeter of the square is " + peri);
    }

}