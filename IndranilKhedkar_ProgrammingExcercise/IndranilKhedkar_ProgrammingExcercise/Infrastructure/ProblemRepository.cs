using IndranilKhedkar_ProgrammingExcercise.Algorithms.Array;
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
                }
            };
        }
    }
}
