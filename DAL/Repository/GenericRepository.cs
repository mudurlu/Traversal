
using DAL.Abstract;
using DAL.Concrete;

namespace DAL.Repository
{
    public class GenericRepository<Entity> : IGenericDAL<Entity> where Entity : class
    {
        
        public void Ekle(Entity entity)
        {
            using var con = new Context();
            con.Add(entity);
        }

        public void Guncelle(Entity entity)
        {
            using var con = new Context();
            con.Update(entity);
        }

        public List<Entity> Listele()
        {
            using var con = new Context();
            return con.Set<Entity>().ToList();
        }

        public void Sil(Entity entity)
        {
            using var con = new Context();
            con.Remove(entity);
            con.SaveChanges();
        }
    }
}
