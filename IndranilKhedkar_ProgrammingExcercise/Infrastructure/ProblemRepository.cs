using IndranilKhedkar_ProgrammingExcercise.Algorithms.Arrays;
using IndranilKhedkar_ProgrammingExcercise.Models;
using System.Collections.Generic;

namespace IndranilKhedkar_ProgrammingExcercise.Infrastructure
{
    public static class ProblemRepository
    {
        public static List<Problem> ProblemList;
        public static List<Problem> GetProblems()
        {
            return ProblemList;
        }

        public static List<Problem> GetProblems(Category category)
        {
            return ProblemList.FindAll(p=>p.Category.Equals(category));
        }

        static ProblemRepository()
        {
            ProblemList = new List<Problem>()
            {
                new Problem(){
                    Category = Category.Strings,
                    ProblemId = "1",
                    ProblemClassObject = new Problem1(),
                    Statement = "Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? (Assume string is ASCII based.)"
                },
                new Problem(){
                    Category = Category.Strings,
                    ProblemId = "2",
                    ProblemClassObject = new Problem2(),
                    Statement = "Write code to reverse a C-Style String. (C-String means that “abcd” is represented as five characters, including the null character.)"
                },
                new Problem(){
                    Category = Category.Strings,
                    ProblemId = "3",
                    ProblemClassObject = new Problem3(),
                    Statement = "Given two strings, write a method to decide if one is a permutation of the other"
                },
                new Problem(){
                    Category = Category.Strings,
                    ProblemId = "4",
                    ProblemClassObject = new Problem4(),
                    Statement = "Write a method to replace all spaces in a string with '%20'. You may assume that the string has sufficient space at the end of the string to hold the additional characters," +
                    "and that you are given the true length of the string. (Note: if implementing in Java,please use a character array so that you can perform this operation in place.)"
                }
            };
        }
    }
}
