using System.ComponentModel.DataAnnotations;

namespace Bankster.Models
{
    public class Banka
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(50)]
        public string Sediste { get; set; }

        [Required]
        [Range(100, 999)]
        public int Kod { get; set; }

    }
}
