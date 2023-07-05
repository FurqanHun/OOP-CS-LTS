namespace L9_c;

class Program
{
       static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of Array: ");
        int size = int.Parse(System.Console.ReadLine());

        int[] intMyArray1 = new int[size];
        int[] intMyArray2 = new int[size];
        int[] inyMyRsultantArr = new int[size];
//input
        for(int i=0; i<size; i++)
        {
            System.Console.WriteLine("Enter the {0} value of Array 1: ", i+1);
            intMyArray1[i] = int.Parse(System.Console.ReadLine());
        }
        for(int i=0; i<size; i++)
        {
            System.Console.WriteLine("Enter the {0} value of Array 2: ", i+1);
            intMyArray2[i] = int.Parse(System.Console.ReadLine());
        }
//add
        for (int i = 0; i < size; i++)
        {
            inyMyRsultantArr[i] = intMyArray1[i] + intMyArray2[i];
        }
//print
        System.Console.WriteLine("The sum of two arrays is: ");
        for (int i = 0; i < size; i++)
        {
            System.Console.Write(inyMyRsultantArr[i] + "\n");
        }
}
}
