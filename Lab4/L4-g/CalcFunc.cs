namespace L4_g;
public class CalcFunc
{
    
    public void Add(double x, double y)
    {
        
        double result = x + y;
        
        Console.WriteLine(x + " + " + y + " = " + result);
    }

    
    public void Subtract(double x, double y)
    {
        
        double result = x - y;
        
        Console.WriteLine(x + " - " + y + " = " + result);
    }

    
    public void Multiply(double x, double y)
    {
        
        double result = x * y;
        
        Console.WriteLine(x + " * " + y + " = " + result);
    }

    
    public void Divide(double x, double y)
    {
        
        if (y == 0)
        {
            
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            
            double result = x / y;
            
            Console.WriteLine(x + " / " + y + " = " + result);
        }
    }

    
    public void Power(double x, double y)
    {
        
        double result = Math.Pow(x, y);
        
        Console.WriteLine(x + " ^ " + y + " = " + result);
    }

    
    public void Sqrt(double x)
    {
        
        if (x < 0)
        {
            
            Console.WriteLine("Cannot take square root of a negative number.");
        }
        else
        {
            
            double result = Math.Sqrt(x);
            
            Console.WriteLine("sqrt(" + x + ") = " + result);
        }
    }
}