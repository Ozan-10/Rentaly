using Rentaly.DataAccessLayer.Abstract;
using Rentaly.DataAccessLayer.Concrete;
using Rentaly.DataAccessLayer.RepositoryDesignPattern;
using Rentaly.EntityLayer.Entities;

namespace Rentaly.DataAccessLayer.EntityFramework
{
    public class EfModelDal : GenericRepository<Model>, IModelDal
    {
        public EfModelDal(RentalyContext context) : base(context)
        {
        }
    }
}