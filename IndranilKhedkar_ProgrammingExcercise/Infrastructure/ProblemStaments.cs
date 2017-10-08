using IndranilKhedkar_ProgrammingExcercise.Infrastructure;
using IndranilKhedkar_ProgrammingExcercise.Interface;
using IndranilKhedkar_ProgrammingExcercise.Models;
using System.Collections.Generic;
using System.Linq;

namespace IndranilKhedkar_ProgrammingExcercise
{
    public class ProblemStatements : IProblemStatements
    {
        public List<Problem> GetProblemList()
        {
            return ProblemRepository.GetProblems();       
        }

        public List<Problem> GetProblemList(Category Category)
        {
            return ProblemRepository.GetProblems(Category);
        }

        public Problem GetProblemByProblemId(string ProblemId, Category category)
        {
            return ProblemRepository.GetProblems().FirstOrDefault(p => p.ProblemId.Equals(ProblemId) && p.Category.Equals(category));
        }
    }
}
