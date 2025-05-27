using DAL.Abstract;
using DAL.Repository;
using EntityLayer.Concrete;

namespace DAL.EntityFramework
{
    public class EfLokasyonDAL : GenericRepository<Lokasyon>, ILokasyonDAL
    {
    }
}
