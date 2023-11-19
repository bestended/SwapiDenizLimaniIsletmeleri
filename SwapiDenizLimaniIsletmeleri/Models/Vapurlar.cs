using System.ComponentModel.DataAnnotations;

namespace SwapiDenizLimaniIsletmeleri.Models
{
    public class Vapurlar
    {

        [Key]
        public int VapurId { get; set; }
        public string? VapurAdi { get; set; }
        public string? VapurTipi { get; set; }
        public int MotorSayisi { get; set; }

        public int Uzunluk { get; set; }
        public int Genislik { get; set; }
        public int BacaSayisi { get; set; }
        public int KoltukSayisi { get; set; }


    }
}
