using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace IndranilKhedkar_ProgrammingExcercise.Algorithms.Arrays
{
    /// <summary>
    /// Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end of the string to hold the additional characters,
    /// and that you are given the "true" length of the string. (Note: if implementing in Java, please use a character array so that you can perform this operation in place.)
    /// </summary>
    public class Problem4
    {
        public void Run()
        {
            Console.Write("Enter input string: ");
            string str = Console.ReadLine();
            Console.WriteLine($"First Implementation: Output String - {ReplaceSpaces(str)}");
        }

        /// <summary>
        /// Implementation of replacing spaces with "%20" using StringBuilder
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReplaceSpaces(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char ch in str)
            {
                if (char.IsWhiteSpace(ch))
                    result.Append("%20");
                else
                    result.Append(ch);
            }
            return result.ToString();
        }
    }
}
