namespace L5_2;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int English { get; set; }
    public int Math { get; set; }
    public int Science { get; set; }
    public int Total { get; set; }
    public int obtainedMarks { get; set; }
    public double percentage { get; set; }

    public void CalculateTotal()
    {
        Total = English + Math + Science;
    }
    public void CalculatePercentage()
    {
        percentage = Total / 3;
    }

}
