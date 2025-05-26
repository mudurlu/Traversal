
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Bulten
    {
        [Key]
        public int BultenId { get; set; }
        public string Mail { get; set; }
        
    }
}
