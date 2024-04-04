using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        public List<Destination> GetDestinationWithGuide(int id);
    }
}