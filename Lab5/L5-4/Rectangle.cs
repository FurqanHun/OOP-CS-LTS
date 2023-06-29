namespace L5_4;

public class Rectangle
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Area { get; set; }
    public int Perimiter { get; set; }

    public void CalculatePerimiter()
    {
       Perimiter = 2 * (Length + Width);
    }
    public void CalculateArea()
    {
        Area = Length * Width;
    }
   
   public bool IsSquare()
   {
       if (Length == Width)
       {
           return true;
       }
       else
       {
           return false;
       }
   }
}
