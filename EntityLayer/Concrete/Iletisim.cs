
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int IletisimId { get; set; }
        public string Aciklama { get; set; }

        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Harita { get; set; }
        public bool Durum { get; set; }
    }
}
