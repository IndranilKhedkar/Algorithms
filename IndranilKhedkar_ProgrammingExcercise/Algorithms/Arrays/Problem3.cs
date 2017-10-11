using System;
using System.Collections;
using System.Linq;

namespace IndranilKhedkar_ProgrammingExcercise.Algorithms.Arrays
{
    /// <summary>
    /// Cracking coding interview questions - Arrays and Strings - Question 3
    /// Given two strings, write a method to decide if one is a permutation of the other
    /// </summary>
    public class Problem3
    {
        public void Run()
        {
            Console.Write("Enter first input string: ");
            char[] str1 = Console.ReadLine().ToCharArray();
            Console.Write("Enter Second input string: ");
            char[] str2 = Console.ReadLine().ToCharArray();
            Console.WriteLine($"First Implementation: {new string(str1)} {(IsPermutation1(str1,str2) ? "is" : "is not")} permutation of {new string(str2)}");
            Console.WriteLine($"Second Implementation: {new string(str1)} {(IsPermutation2(str1, str2) ? "is" : "is not")} permutation of {new string(str2)}");
        }

        /// <summary>
        ///  Assuming str contains only ASCII charecters below method will check whether str1 is permutation of str2
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool IsPermutation1(char[] str1, char[] str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int[] charCount = new int[256];
            foreach (char ch in str1)
                charCount[(int)ch]++;

            foreach (char ch in str2)
            {
                if ((--charCount[(int)ch]) < 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Below implementation sorts both charecter arrays and then compares both by doing sequencial chrecter matching
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public bool IsPermutation2(char[] str1, char[] str2)
        {
            if (str1.Length != str2.Length)
                return false;

            Array.Sort(str1);
            Array.Sort(str2);
            return str1.SequenceEqual(str2);
        }
    }
}
