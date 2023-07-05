namespace L10_1;

public interface IAnimal
{
    public void Speak();
    public void Move();

}
public interface IBird
{
    public void Eat();
    public void LayEgg();
}

public class Penguin : IAnimal , IBird
{
    public void Speak()
    {
        Console.WriteLine("Meow...Meow...Meow...");
    }
    public void Move()
    {
        Console.WriteLine("Penguin moves on 4 legs..haha");
    }
    public void Eat()
    {
        Console.WriteLine("Penguin eats fish.. fish killer");
    }
    public void LayEgg()
    {
        Console.WriteLine("Penguin lays egg.. EGG");
    }
}