using System;
namespace L4_d;
    public class EvenOddClass
    {
        public void CheckEvOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is even.");
            }
            else
            {
                Console.WriteLine(n + " is odd.");
            }
        }
    }
