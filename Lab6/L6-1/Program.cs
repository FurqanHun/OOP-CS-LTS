namespace L6_1;

class Program
{
    static void Main(string[] args)
    {
        GetSet person = new GetSet();
        Console.WriteLine("Enter name: ");
        person.Name = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        person.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}
