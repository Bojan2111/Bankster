using System;

namespace Bankster.Models.DTOs
{
    public class TransakcijaDTO
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string UplatilacRacun { get; set; }
        public string UplatilacPunoIme { get; set; }
        public string PrimalacRacun { get; set; }
        public string PrimalacPunoIme { get; set; }
        public decimal Iznos { get; set; }
        public bool Hitno { get; set; } = false;
    }
}
