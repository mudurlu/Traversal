using DAL.Abstract;
using DAL.Repository;
using EntityLayer.Concrete;

namespace DAL.EntityFramework
{
    public class EfBultenDAL : GenericRepository<Bulten>, IBultenDAL
    {
    }
}
