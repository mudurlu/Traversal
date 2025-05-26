using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaId { get; set; }
        public string Title { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
    }
}
