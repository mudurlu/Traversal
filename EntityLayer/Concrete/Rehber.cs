
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Rehber
    {
        [Key]
        public int RehberId { get; set; }
        public string RehberAdi { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
    }
}
