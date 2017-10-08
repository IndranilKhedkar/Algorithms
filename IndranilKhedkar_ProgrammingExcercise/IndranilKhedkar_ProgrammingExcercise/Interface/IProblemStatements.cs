using IndranilKhedkar_ProgrammingExcercise.Models;
using System.Collections.Generic;

namespace IndranilKhedkar_ProgrammingExcercise.Interface
{
    interface IProblemStatements
    {
        // Gets list of all problems
        List<Problem> GetProblemList();

        // Gets list of problems based on input problem category
        List<Problem> GetProblemList(Category Category);

        Problem GetProblemByProblemId(string ProblemId, Category category);
    }
}
