namespace L9_b;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 6, 7, 8, 9, 10 };
        int[] sum = new int[5];
//add
        for (int i = 0; i < arr1.Length; i++)
        {
            sum[i] = arr1[i] + arr2[i];
        }
//print
        for (int i = 0; i < sum.Length; i++)
        {
            System.Console.Write(sum[i] + "\n");
        }
    }

}
