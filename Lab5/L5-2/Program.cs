namespace L5_2;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Furqan";
        student.Age = 19;
        student.English = 80;
        student.Math = 90;
        student.Science = 70;
        student.CalculateTotal();
        student.CalculatePercentage();
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("English: " + student.English);
        Console.WriteLine("Math: " + student.Math);
        Console.WriteLine("Science: " + student.Science);
        Console.WriteLine("Total: " + student.Total);
        Console.WriteLine("Percentage: " + student.percentage);
    }
}
