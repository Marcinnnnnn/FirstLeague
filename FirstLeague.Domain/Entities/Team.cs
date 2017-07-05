namespace FirstLeague.Domain.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }        
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Defeat { get; set; }
        public int Score { get; set; }
        public int GoalS { get; set; }
        public int GoalL { get; set; }
    }
}