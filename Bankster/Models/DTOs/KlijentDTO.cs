using System.ComponentModel.DataAnnotations;
using System;

namespace Bankster.Models.DTOs
{
    public class KlijentDTO
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Rodjenje { get; set; }
        public string Forma { get; set; }

        //public static explicit operator KlijentDTO(Klijent klijent)
        //{
        //    return new KlijentDTO()
        //    {
        //        // Use this if you want to calculate something later call this var klijentDto = (KlijentDTO) klijent
        //    };
        //}
    }
}
