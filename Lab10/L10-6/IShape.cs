namespace L10_6;
public interface IShape
{
    void SName();
    void ShArea();

}
public class Rectangle : IShape
{
    public void SName()
    {
        Console.WriteLine("Enter the name of the shape: ");
        string name = Console.ReadLine();
        Console.WriteLine("The name of the shape is: " + name);
    }
    public void ShArea()
    {
        Console.WriteLine("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        double area = length * width;
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}

public class Circle : IShape
{
    public void SName()
    {
        Console.WriteLine("Enter the name of the shape: ");
        string name = Console.ReadLine();
        Console.WriteLine("The name of the shape is: " + name);
    }
    public void ShArea()
    {
        Console.WriteLine("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("The area of the circle is: " + area);
    }
}
