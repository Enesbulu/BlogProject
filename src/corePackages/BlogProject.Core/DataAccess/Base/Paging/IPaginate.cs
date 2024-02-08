namespace BlogProject.Core.DataAccess.Base.Paging
{
    public interface IPaginate<T>
    {
        int From { get; set; }
        int Index{ get; set; }
        public int Size { get; set; }
        int Count { get; set; }
        int Pages { get; set; }
        IList<T> Items { get; set; }
        bool HasPrevious { get; }
        bool HasNext { get; }
    }
}
