
using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IBLLVeriOlusturma<TEntity> : IGenelBLLOperasyonlari
        where TEntity : class, IEntity, new()

    {
        IResult AddService(TEntity entity);
    }
}
