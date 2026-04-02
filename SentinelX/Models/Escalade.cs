namespace SentinelX.Models
{
    public class Escalade
    {
        public int id { get; set; }
        public int alerdeId { get; set; }
        public int etape { get; set; }
        public string description { get; set; }
        public DateTime dateHeure { get; set; }
        public string statut { get; set; }
    }
}
