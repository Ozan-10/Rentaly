using Rentaly.EntityLayer.Entities;

namespace Rentaly.BusinessLayer.Abstract
{
    public interface IProcessService
    {
        Task<List<Process>> TGetListAsync();
        Task TInsertAsync(Process entity);
        Task TDeleteAsync(int id);
        Task<Process> TGetByIdAsync(int id);
        Task TUpdateAsync(Process entity);
    }
}