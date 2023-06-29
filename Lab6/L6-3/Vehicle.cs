namespace L6_3;
public class Vehicle
{
    private string make;
    private string model;
    private int year;
    private string color;

    public Vehicle(string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }
    public string GetMake()
    {
        return make;
    }
    public void SetMake(string make)
    {
        this.make = make;
    }
    public string GetModel()
    {
        return model;
    }
    public void SetModel(string model)
    {
        this.model = model;
    }
    public int GetYear()
    {
        return year;
    }
    public void SetYear(int year)
    {
        this.year = year;
    }
    public string GetColor()
    {
        return color;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }

}
