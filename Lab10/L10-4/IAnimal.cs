namespace L10_4;

public interface IAnimal
{
    public void AName();
}
public class InterImp : IAnimal{

    string type;
    string name;

    public InterImp(string type, string name){
        this.name = name;
        this.type = type;
    }
    public void AName(){
        if(type == "dog" || type == "DOG" || type == "Dog" || type == "cat" || type == "CAT" || type == "Cat"){
            System.Console.WriteLine("\n\nI am a {0} and my name is {1}", type, name);
        }
        else{
            System.Console.WriteLine("NAH MAN SUS, CHOOSE EITHER A CAT OR A DOG PLS...");
        }        
    }
}