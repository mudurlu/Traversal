using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGenericDAL <Entity> where Entity : class
    {
        void Ekle(Entity entity);
        void Guncelle(Entity entity);
        void Sil(Entity entity);
        List<Entity> Listele();
    }
}
