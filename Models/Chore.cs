

namespace ChoreScore.Models
{
    public class Chore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        public int TimeToCompleteMin { get; set; }
        public Chore(int id, string name, bool completed, int timeToCompleteMin)
        {
            Id = id;
            Name = name;
            Completed = completed;
            TimeToCompleteMin = timeToCompleteMin;
        }
    }
}
