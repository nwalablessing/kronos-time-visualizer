namespace KronosDashboard.Models
{
    public class RttMetric
    {
        public string DataCenter { get; set; }
        public int Rtt { get; set; }
        public string Role { get; set; }   // Oracle or Follower
        public double Delta { get; set; }  // Sync drift in seconds
    }
}
