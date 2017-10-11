using System;
using System.Collections;

namespace IndranilKhedkar_ProgrammingExcercise.Algorithms.Arrays
{
    /// <summary>
    /// Cracking coding interview questions - Arrays and Strings - Question 2    
    /// Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.)
    /// </summary>
    public class Problem2
    {
        public void Run()
        {
            Console.Write("Enter input string: ");
            string str = Console.ReadLine();
            char[] inputString = str.ToCharArray();
            Console.WriteLine($"First Implementation:\n\tOriginal String: {str}\n\tReversed String: {ReverseString1(inputString)}");
            Console.WriteLine($"Second Implementation:\n\tOriginal String: {str}\n\tReversed String: {ReverseString2(inputString)}");
        }
        private string ReverseString1(char[] str)
        {
            char[] output = new char[str.Length];
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
            {
                output[i] = str[j];
                output[j] = str[i];
            }
            return new string(output);
        }
        private string ReverseString2(char[] str)
        {
            char ch;
            int len = str.Length-1;
            if (len == 1)
                return new string(str);

            for (int i = 0; i < str.Length / 2; i++, len--)
            {
                ch = str[i];
                str[i] = str[len];
                str[len] = ch;
            }
            return new string(str);
        }
    }
}
