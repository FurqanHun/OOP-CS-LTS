namespace L5_3;

class Program
{
    static void Main(string[] args)
    {
        CalculateVowels cv = new CalculateVowels();
        string str = "Muhammad Furqan Khalil";
        int count = cv.VowelCount(str);
        Console.WriteLine("Number of vowels in {0} is {1}", str, count);
    }
}
