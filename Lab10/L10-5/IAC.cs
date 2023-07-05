namespace L10_5;

public interface IAC
{
    public void ACOn();
    public void ACOff();
}

public class ACInterImp : IAC{
    public void ACOn(){
        System.Console.WriteLine("\n\nAC On...\n");
    }
    public void ACOff(){
        System.Console.WriteLine("\n\nAC Off...\n");
    }
}