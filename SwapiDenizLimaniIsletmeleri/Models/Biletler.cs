using System.ComponentModel.DataAnnotations;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class Biletler
    {

        [Key]
        public int BiletId { get; set; }
        public string? Pnr { get; set; }
        public DateTime TarihSaat { get; set; }
        public decimal  Fiyat { get; set; }


    }
}
