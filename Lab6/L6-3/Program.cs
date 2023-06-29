namespace L6_3;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle("Ford", "F-150", 2018, "Blue");
        Vehicle vehicle2 = new Vehicle("Toyota", "Camry", 2017, "Red");
        Vehicle vehicle3 = new Vehicle("Honda", "Civic", 2016, "Green");

        Console.WriteLine("Vehicle 1: {0} {1} {2} {3}", vehicle1.GetMake(), vehicle1.GetModel(), vehicle1.GetYear(), vehicle1.GetColor());
        Console.WriteLine("Vehicle 2: {0} {1} {2} {3}", vehicle2.GetMake(), vehicle2.GetModel(), vehicle2.GetYear(), vehicle2.GetColor());
        Console.WriteLine("Vehicle 3: {0} {1} {2} {3}", vehicle3.GetMake(), vehicle3.GetModel(), vehicle3.GetYear(), vehicle3.GetColor());
    }
}
