using System.ComponentModel.DataAnnotations;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class Sirketler
    {
        [Key]
        public int SirketId { get; set; }
        public string? SirketAdi { get; set; }
        public decimal Bütcesi { get; set; }
        public string? Yeri { get; set; }
        public string? Telefon { get; set; }
        public string? Mail { get; set; }

    }
}
