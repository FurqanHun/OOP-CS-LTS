namespace oopA2;

class Program
{
    static void Main(string[] args)
    {
        ISBN book1 = new ISBN("C# Programming", "Furqan", "SMIU", 1000, "1/1/2023", "Karachi", "123");
        book1.printDetails();
    }
}
