using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Referans
    {
        [Key]
        public int ReferansId { get; set; }
        public string Musteri { get; set; }
        public string Yorum { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
    }
}
