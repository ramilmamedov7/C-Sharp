using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 100; k <= 200; k++)
            {
                string data = k.ToString();
                bool isPalindrome = true;
                for (int i = 0; i < data.Length / 2; i++)
                {
                    if (data[i] != data[(data.Length - 1) - i])
                    {
                        isPalindrome = false;
                    }
                }
                    if (isPalindrome)
                {
                    Console.WriteLine("Palindrome :" + k);
                }
            }
            Console.ReadLine();
        }
    }
}