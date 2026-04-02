namespace SentinelX.Models
{
    public enum Role { Admin, Employé }
    public class Travailleur
    {
        public int id { get; set; }
        public string nom { get; set; } = string.Empty;
        public string courriel { get; set; } = string.Empty;
        public string telephone { get; set; } = string.Empty;
        public Role role { get; set; }
        public string motDePasse { get; set; } = string.Empty;
        public List<Alerte> alertes { get; set; }
    }
}
