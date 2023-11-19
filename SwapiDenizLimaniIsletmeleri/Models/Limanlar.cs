using System.ComponentModel.DataAnnotations;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class Limanlar
    {
        [Key]
        public int LimanId { get; set; }
        public string? LimanYeri { get; set; }
        public int Kapasitesi { get; set; }
        public int Genislik { get; set; }
        public int CalisanAdet { get; set; }
        public int KoltukSayi { get; set; }

    }
}
