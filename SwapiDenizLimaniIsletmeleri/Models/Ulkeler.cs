using System.ComponentModel.DataAnnotations;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class Ulkeler
    {
        [Key]
        public int UlkeId { get; set; }
        public string? Sehir { get; set; }

        public int PostaKodu { get; set; }
        public string? Baskenti { get; set; }
        public int Nufus { get; set; }




    }
}
