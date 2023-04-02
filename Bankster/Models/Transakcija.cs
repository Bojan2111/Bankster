using System;

namespace Bankster.Models
{
    public class Transakcija
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int UplatilacRacunId { get; set; }
        public Racun UplatilacRacun { get; set; }
        public int PrimalacRacunId { get; set; }
        public Racun PrimalacRacun { get; set; }
        public decimal Iznos { get; set; }
        public bool Hitno { get; set; } = false;
    }
}
