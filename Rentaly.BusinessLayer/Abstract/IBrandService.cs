using Rentaly.EntityLayer.Entities;

namespace Rentaly.BusinessLayer.Abstract
{
    public interface IBrandService
    {
        Task<List<Brand>> TGetListAsync();
        Task<Brand> TGetByIdAsync(int id);
        Task TInsertAsync(Brand entity);
        Task TUpdateAsync(Brand entity);
        Task TDeleteAsync(int id);
    }
}