using DAL.Abstract;
using DAL.Repository;

using EntityLayer.Concrete;
namespace DAL.EntityFramework
{
    public class EfHakkimizdaDAL : GenericRepository<Hakkimizda>, IHakkimizdaDAL
    {
    }
}
