using DAL.Abstract;
using DAL.Repository;
using EntityLayer.Concrete;

namespace DAL.EntityFramework
{
    public class EfIletisimDAL : GenericRepository<Iletisim>, IIletisimDAL
    {
    }
}
