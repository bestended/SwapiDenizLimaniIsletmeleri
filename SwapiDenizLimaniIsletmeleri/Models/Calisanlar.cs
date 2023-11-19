using System.ComponentModel.DataAnnotations;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class Calisanlar
    {
        [Key]
        public int CalisanId { get; set; }
        public string? ZabitAdSoyad { get; set; }
        public string? BasMakinistAdSoyad { get; set; }
        public int TemizlikciSayi { get; set; }


    }
}
