using System.ComponentModel.DataAnnotations;

namespace Bankster.Models
{
    public class Pol
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(20)]
        public string Forma { get; set; }
    }
}
