namespace BusinessLayer.Abstract
{
    public interface IGenericService<Entity> where Entity : class
    {
        void Ekle(Entity entity);
        void Guncelle(Entity entity);
        List<Entity> Listele();
        Entity Getir(int id);
        void Sil(Entity entity);
    }
}
