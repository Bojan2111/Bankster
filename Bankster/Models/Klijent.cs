using System;
using System.ComponentModel.DataAnnotations;

namespace Bankster.Models
{
    public class Klijent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Ime { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Prezime { get; set; }

        [Required]
        public DateTime Rodjenje { get; set; }

        public int PolId { get; set; }

        public Pol Pol { get; set; }
    }
}
