using BlogProject.Core.DataAccess.Base.Paging;

namespace BlogProject.Core.Business.Concrete
{
    public class GetListResponse<T> : BasePageableModel
    {
        private IList<T>? _items;
        public IList<T> Items
        {
            get => _items ??= new List<T>();
            set => _items = value;
        }
    }
}
