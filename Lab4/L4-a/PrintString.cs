namespace L4_a;
public class PrintString
{
    string str;
    public PrintString(string s)
    {
        str = s;
    }
    public void print()
    {
        Console.WriteLine("your name is {0}", str);
    }
}
