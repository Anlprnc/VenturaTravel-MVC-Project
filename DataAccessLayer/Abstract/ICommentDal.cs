using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        public List<Comment> GetListCommentWithDestiantion();
        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}