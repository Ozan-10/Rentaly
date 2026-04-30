using Rentaly.EntityLayer.Entities;

namespace Rentaly.BusinessLayer.Abstract
{
    public interface IAboutService
    {
        Task<List<About>> TGetListAsync();
        Task TInsertAsync(About entity);
        Task TDeleteAsync(int id);
        Task<About> TGetByIdAsync(int id);
        Task TUpdateAsync(About entity);
    }
}