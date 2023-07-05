namespace L9_d;

class Program
{
    static void Main(string[] args)
    {
         System.Console.WriteLine("Enter the size of Array: ");
        int size = int.Parse(System.Console.ReadLine());

        int[] arr = new int[size];
        int[] resultArr = new int[size];
//input
        for(int i=0; i<size; i++)
        {
            System.Console.WriteLine("Enter the {0} Integer value of Array: ", i+1);
            arr[i] = int.Parse(System.Console.ReadLine());
        }

        for (int i = 0; i < size; i++)
        {
            resultArr[i] = arr[i] * 2;
        }
//print
        System.Console.WriteLine("Original array: ");
        for (int i = 0; i < size; i++)
        {
            System.Console.Write(arr[i] + "\n");
        }

        System.Console.WriteLine("The array after being *2 is: ");
        for (int i = 0; i < size; i++)
        {
            System.Console.Write(resultArr[i] + "\n");
        }
    }
}
