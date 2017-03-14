namespace _247.Models
{
    //class to capture details associated to an issue
    public class Issue
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        public string ContactNumber { get; set; }

        public string ProblemDescription { get; set; }

       // public ICollection<Issue> IssuesRecorded { get; set; }
    }
}