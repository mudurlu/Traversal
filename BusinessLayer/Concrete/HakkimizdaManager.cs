using BusinessLayer.Abstract;
using DAL.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HakkimizdaManager : IHakkimizdaService
    {
        IHakkimizdaDAL _hakkimizdaDAL;
        public HakkimizdaManager(IHakkimizdaDAL hakkimizdaDAL)
        {
            _hakkimizdaDAL = hakkimizdaDAL;
        }
        public void Ekle(Hakkimizda entity)
        {
            _hakkimizdaDAL.Ekle(entity);
        }

        public Hakkimizda Getir(int id)
        {
            return _hakkimizdaDAL.Getir(id);
        }

        public void Guncelle(Hakkimizda entity)
        {
            _hakkimizdaDAL.Guncelle(entity);
        }

        public List<Hakkimizda> Listele()
        {
            
            return _hakkimizdaDAL.Listele();
        }

        public void Sil(Hakkimizda entity)
        {
            _hakkimizdaDAL.Sil(entity);
        }
    }
}
