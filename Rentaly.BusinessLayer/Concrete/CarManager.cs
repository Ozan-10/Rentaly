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
    public class CarManager : ICarService
    {
        private readonly ICarDal _cardal;

        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public async Task TDeleteAsync(int id)
        {
            await _cardal.DeleteAsync(id);
        }

        public async Task<List<Car>> TGetAllCarsWithCategoryAsync()
        {
            return await _cardal.GetAllCarsWithCategoryAsync(); 
        }

        public async Task<Car> TGetByIdAsync(int id)
        {
            return await _cardal.GetByIdAsync(id);
        }

        public async Task<List<Car>> TGetListAsync()
        {
            return await _cardal.GetListAsync();
        }

        public async Task TInsertAsync(Car entity)
        {
           await _cardal.InsertAsync(entity);
        }

        public async Task TUpdateAsync(Car entity)
        {
            await _cardal.UpdateAsync(entity);
        }
    }
}
