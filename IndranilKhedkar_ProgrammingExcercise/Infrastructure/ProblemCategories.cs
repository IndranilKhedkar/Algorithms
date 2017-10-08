using IndranilKhedkar_ProgrammingExcercise.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IndranilKhedkar_ProgrammingExcercise
{
    public class ProblemCategories : IProblemCategories
    {
        public List<Category> GetCategories()
        {
            return Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
        }

        public Category GetCategoryUsingValue(int categoryValue)
        {
            return (Category)categoryValue;
        }
    }

    [Flags]
    public enum Category
    {
        None =0,
        Array=1,
        Strings=2,
        Stack=3,
        Queue=4,
        Tree=5,
        Graph=6,
        Bit_Manipulation=7,
        Brain_Teasers=8,
        Mathematics=9,
        Probability=10,
        OODesign=11,
        Recursion=12,
        Dynamic_Programming=13,
        Scalability=14,
        Memory_Limits=15,
        Sorting=16,
        Searching=17,
        Testing=18
    }
}
