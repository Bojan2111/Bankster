namespace Bankster.Models.DTOs
{
    public class RacunDTO
    {
        public int Id { get; set; }
        public string Broj { get; set; }
        public int KontrolniBroj { get; set; }
        public decimal Saldo { get; set; }
        public string Tip { get; set; }
        public string BankaNaziv { get; set; }
        public int BankaKod { get; set; }
        public string KlijentIme { get; set; }
        public string KlijentPrezime { get; set; }
    }
}
