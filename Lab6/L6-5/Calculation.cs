namespace L6_5;
public class Calculation
{
    private int a;
    private int b;
    public Calculation(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void Add()
    {
        System.Console.WriteLine("Addition: " + (a + b));
    }

    public void Subtract()
    {
        System.Console.WriteLine("Subtraction: " + (a - b));
    }
}
