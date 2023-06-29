namespace L5_3;

public class CalculateVowels
{
    public int VowelCount(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        return count;
    }
}
