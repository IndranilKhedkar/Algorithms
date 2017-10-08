namespace IndranilKhedkar_ProgrammingExcercise.Models
{
    public class Problem
    {
        public string ProblemId { get; set; }
        public Category Category { get; set; }
        public string Statement { get; set; }
        public object ProblemClassObject { get; set; }
    }
}
