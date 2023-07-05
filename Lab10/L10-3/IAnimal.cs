namespace L10_3;

public interface IAnimal
{
    public void AName();
}
public class InterImp : IAnimal{
    public void AName(){
        System.Console.WriteLine("Enter yo CAT name: ");
        string name = Console.ReadLine();

        System.Console.WriteLine("\n\nI am a cat and my name is " + name);
    }
}