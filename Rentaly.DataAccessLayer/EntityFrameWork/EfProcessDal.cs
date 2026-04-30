using Rentaly.DataAccessLayer.Abstract;
using Rentaly.DataAccessLayer.Concrete;
using Rentaly.DataAccessLayer.RepositoryDesignPattern;
using Rentaly.EntityLayer.Entities;

namespace Rentaly.DataAccessLayer.EntityFramework
{
    public class EfProcessDal : GenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(RentalyContext context) : base(context)
        {
        }
    }
}