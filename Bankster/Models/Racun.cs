using System.ComponentModel.DataAnnotations;

namespace Bankster.Models
{
    public class Racun
    {
        public int Id { get; set; }
        [Required]
        [StringLength(13, MinimumLength = 1)]
        public string Broj { get; set; }
        public int KontrolniBroj { get; set; }
        public decimal Saldo { get; set; }
        public int TipRacunaId { get; set; }
        public TipRacuna TipRacuna { get; set; }
        public int KlijentId { get; set; }
        public Klijent Klijent { get; set; }
        public int BankaId { get; set; }
        public Banka Banka { get; set; }
    }
}
