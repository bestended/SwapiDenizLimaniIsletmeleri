using System.ComponentModel.DataAnnotations;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class Yolcular
    {
        [Key]
        public int YolcuId { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Telefon { get; set; }
        public string? Mail { get; set; }

    }
}
