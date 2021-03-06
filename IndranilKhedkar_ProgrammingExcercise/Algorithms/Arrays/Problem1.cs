﻿using System;
using System.Collections;

namespace IndranilKhedkar_ProgrammingExcercise.Algorithms.Arrays
{
    /// <summary>
    /// Cracking coding interview questions - Arrays and Strings - Question 1
    /// Implement an algorithm to determine if a string has all unique characters.
    /// What if you cannot use additional data structures? (Assume string is ASCII based.)
    /// </summary>
    public class Problem1
    {
        public void Run()
        {
            Console.Write("Enter input string: ");
            string str = Console.ReadLine();
            Console.WriteLine($"First Implementation - String {str} {(hasUniqueChars(str) ? "has" : "dont have")} all unique charecters.");
            Console.WriteLine($"Second Implementation - String {str} {(hasUniqueChars2(str) ? "has" : "dont have")} all unique charecters.");
            Console.WriteLine($"Third Implementation - String {str} {(hasUniqueChars3(str) ? "has" : "dont have")} all unique charecters.");

        }
        public static bool hasUniqueChars(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;
            if (str.Length > 256) return false;

            bool[] charSet = new bool[256];
            for (int i = 0; i < str.Length; ++i)
            {
                char ch = str[i];
                if (charSet[ch]) return false;
                else charSet[ch] = true;
            }
            return true;
        }

        public static bool hasUniqueChars2(String str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;
            if (str.Length > 256) return false;

            int bitVector = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                char ch = str[i];
                if ((bitVector & (1 << ch)) > 0) return false;
                else bitVector |= (1 << ch);
            }
            return true;
        }

        // Implementation using HashTable 
        public static bool hasUniqueChars3(String str)
        {
            Hashtable hashtable = new Hashtable();
            string input;
            bool resultFlag = true;

            input = Console.ReadLine();
            foreach (char c in input)
            {
                if (hashtable.ContainsKey(c))
                {
                    resultFlag = false;
                    break;
                }
                hashtable.Add(c, true);
            }
            return resultFlag;
        }
    }
}
