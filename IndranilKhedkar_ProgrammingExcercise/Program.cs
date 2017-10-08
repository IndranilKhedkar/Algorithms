using IndranilKhedkar_ProgrammingExcercise.Interface;
using System;
using System.Reflection;
using System.Threading;

namespace IndranilKhedkar_ProgrammingExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IProblemCategories problemCategories = new ProblemCategories();
            IProblemStatements problemStatements = new ProblemStatements();
            int i = 1, categoryId, problemId;

            Console.WriteLine("---------------PLEASE SELECT PROBLEM CATEGORY---------------");
            Console.WriteLine("------------------------------------------------------------");
            var categories = problemCategories.GetCategories();
            foreach (var category in categories)
            {
                if (Category.None == category)
                    continue;
                Console.WriteLine($"{i++}. {category.ToString()}");
            }
            Console.Write("\nENTER CATEGORY ID: ");
            while (!int.TryParse(Console.ReadLine(), out categoryId))
            {
                Console.Write("PLEASE ENTER VALID CATEGORY ID: ");
            }
            var problems = problemStatements.GetProblemList(Category: problemCategories.GetCategoryUsingValue(categoryId));

            if (problems == null || problems.Count <= 0)
                Console.WriteLine("SORRY...... NO PROBLEM INCLUDED IN THIS CATEGORY YET");
            else
            {
                foreach (var p in problems)
                {
                    Console.WriteLine($"{p.ProblemId}. {p.Statement}");
                }

                Console.Write("SELECT PROBLEM ID: ");
                while (!int.TryParse(Console.ReadLine(), out problemId))
                {
                    Console.Write("PLEASE ENTER VALID CATEGORY ID: ");
                }

                var problem = problemStatements.GetProblemByProblemId(ProblemId: problemId.ToString(), category: problemCategories.GetCategoryUsingValue(categoryId));
                if (problem == null)
                    Console.WriteLine("SORRY......UNABLE TO FIND PROBLEM WITH INPUT PROBLEM ID");
                else
                {
                    Console.WriteLine("PREPARING FOR THE EXECUTION OF SELECTED PROGRAM");
                    Thread.Sleep(1500);
                    Console.WriteLine("Yippeee! All set... Continuing with the execution of requested program");

                    object obj = problem.ProblemClassObject;
                    MethodInfo methodInfo = obj.GetType().GetMethod("Run");

                    if (methodInfo != null)
                    {
                        methodInfo.Invoke(obj, null);
                    }

                    Console.WriteLine("PROGRAM EXEUCTED SUCCESSFULY");
                }
            }
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
