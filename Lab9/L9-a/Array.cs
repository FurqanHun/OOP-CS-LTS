namespace L9_a;
public class Array
{
    public int[] integerArray = new int[5];
    public string[] stringArray = new string[5];
    public double[] doubleArray = new double[5];

    public Array()
    {
        Console.WriteLine("Enter the size of the integer array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        integerArray = new int[size];
        Console.WriteLine("Enter the size of the string array: ");
        size = Convert.ToInt32(Console.ReadLine());
        stringArray = new string[size];
        Console.WriteLine("Enter the size of the double array: ");
        size = Convert.ToInt32(Console.ReadLine());
        doubleArray = new double[size];
    }
    public void InputArray(){
        Console.WriteLine("Enter the elements of the integer array: ");
        for (int i = 0; i < integerArray.Length; i++)
        {
            integerArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Enter the elements of the string array: ");
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter the elements of the double array: ");
        for (int i = 0; i < doubleArray.Length; i++)
        {
            doubleArray[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    public void printArray()
    {
        Console.WriteLine("Integer Array: ");
        foreach (int i in integerArray)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("String Array: ");
        foreach (string i in stringArray)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Double Array: ");
        foreach (double i in doubleArray)
        {
            Console.WriteLine(i);
        }
    }
}
