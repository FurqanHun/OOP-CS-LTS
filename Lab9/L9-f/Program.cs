namespace L9_f;

class Program
{
    static void Main(string[] args)
     {
         System.Console.WriteLine("Enter the size of Array: ");
        int size = int.Parse(Console.ReadLine());

        string[] array = new string[size];
//input
        for(int i=0; i<size; i++)
        {
            System.Console.WriteLine("Enter the {0} value of Array: ", i+1);
            array[i] = Console.ReadLine();
        }
        PrintArray(array);
        
    }
    public static void PrintArray(string[] array2){
        System.Console.WriteLine("Your given Array is: ");
        for (int i = 0; i < array2.Length; i++)
        {
            System.Console.Write(array2[i] + "\n");
        }

    }
}
