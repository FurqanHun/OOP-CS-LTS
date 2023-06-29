namespace L6_1;

public class GetSet
{
    private string name = "Furqan";
    private int age = 18;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Name cannot be empty");
            }
            else
            {
                name = value;
            }
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Age cannot be negative");
            }
            else
            {
                age = value;
            }
        }
    }
    
}
