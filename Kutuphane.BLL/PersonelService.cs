using Kutuphane.DAL;
using Kutuphane.Model.Entity;

namespace Kutuphane.BLL
{
    public class PersonelService
    {
        private readonly PersonelRepository _repo = new PersonelRepository();

        public List<Personel> GetAll()
        {
            return _repo.GetAll();
        }

        public void Add(Personel personel)
        {
            if (string.IsNullOrWhiteSpace(personel.AdSoyad))
                throw new Exception("Personel adı boş olamaz!");

            _repo.Add(personel);
        }

        public void Update(Personel personel)
        {
            _repo.Update(personel);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
