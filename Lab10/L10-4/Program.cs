namespace L10_4;

class Program
{
    static void Main(string[] args)
    {   System.Console.WriteLine("Enter the animal type: ");
        string type = Console.ReadLine();

        System.Console.WriteLine("Enter the name of the animal: ");
        string name = Console.ReadLine();

       InterImp cn = new InterImp(type, name);
       cn.AName();
    }
}
