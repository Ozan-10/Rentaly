using Rentaly.BusinessLayer.Abstract;
using Rentaly.DataAccessLayer.Abstract;
using Rentaly.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentaly.BusinessLayer.Concrete
{
    public class BrancManager : IBranchService
    {
        private readonly IBranchDal _branchdal;

        public BrancManager(IBranchDal branchdal)
        {
            _branchdal = branchdal;
        }

        public async Task TDeleteAsync(int id)
        {
            await _branchdal.DeleteAsync(id);
        }

        public async Task<Branch> TGetByIdAsync(int id)
        {
            return await _branchdal.GetByIdAsync(id);
        }

        public async Task<List<Branch>> TGetListAsync()
        {
            return await _branchdal.GetListAsync();
        }

        public async Task TInsertAsync(Branch entity)
        {
            await _branchdal.InsertAsync(entity);
        }

        public async Task TUpdateAsync(Branch entity)
        {
           await _branchdal.UpdateAsync(entity);
        }
    }
}
