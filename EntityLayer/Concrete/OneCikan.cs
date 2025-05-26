using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class OneCikan
    {
        [Key]
        public int OneCikanId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
    }
}
