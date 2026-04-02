namespace SentinelX.Models
{
    public class Alerte
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int TravailleurId { get; set; }
        public Travailleur Travailleur { get; set; }
        public DateTime dateHeure { get; set; }
        public string statut { get; set; }
    }
}
