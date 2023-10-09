using System.ComponentModel.DataAnnotations;

namespace monteeCompBack.Models
{
    public class Voiture
    {
        [Key]
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Couleur { get; set; }
        public int Poids { get; set; }

    }
}
