using Core.Entity;

namespace Kutuphane.Model.Entity
{
    public class Yayinevi : IEntity
    {
        public int YayineviId { get; set; }
        public string Ad { get; set; }
        public int? KurulusYili { get; set; }
        public ICollection<YayineviKitap> YayineviKitaplari { get; set; }


    }
}
