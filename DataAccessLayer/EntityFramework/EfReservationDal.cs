using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            throw new NotImplementedException();
        }
    }
}