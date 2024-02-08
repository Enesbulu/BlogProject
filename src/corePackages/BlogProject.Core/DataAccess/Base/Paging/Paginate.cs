
using System.Linq;

namespace BlogProject.Core.DataAccess.Base.Paging
{
    public class Paginate<T> : IPaginate<T>
    {
        public Paginate(IEnumerable<T> source, int index, int size, int from)
        {
            if (source == null) throw new ArgumentException($"index: {index} cannot be less than from: {from}");

            Index = index;
            Size = size;
            From = from;
            Pages = (int)Math.Ceiling(Count / (double)size);
            if (source is IQueryable<T> queryable)
            {
                Count = queryable.Count();
                Items = queryable.Skip((Index - From) * Size).Take(Size).ToList();
            }
            else
            {
                T[] enumareble = source as T[] ?? source.ToArray();
                Count = enumareble.Count();
                Items = enumareble.Skip((Index - From) * Size).Take(Size).ToList();
            }

        }

        public Paginate()
        {
            Items = Array.Empty<T>();
        }

        public int From { get; set; }
        public int Index { get; set; }
        public int Size { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public IList<T> Items { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }

    }

    public class Paginate<TSource, TResult> : IPaginate<TResult>
    {
        public Paginate(IEnumerable<TSource> source, Func<IEnumerable<TSource>, IEnumerable<TResult>> converter, int index, int size, int from)
        {
            if (from > index) throw new ArgumentException($"From: {from.ToString()} > Index: {index.ToString()}, must From <= Index");

            Index = index;
            Size = size;
            From = from;
            Pages = (int)Math.Ceiling(Count / (double)Size);

            if (source is IQueryable<TSource> queryable)
            {
                Count = queryable.Count();
                TSource[] items = queryable.Skip((Index - From) * Size).Take(size).ToArray();
                Items = new List<TResult>(converter(items));
            }
            else
            {
                TSource[] enumerable = source as TSource[] ?? source.ToArray();
                Count = enumerable.Count();
                TSource[] items = enumerable.Skip((Index - From) * Size).Take(size).ToArray();
                Items = new List<TResult>(converter(items));
            }

        }

        public Paginate(IPaginate<TSource> source, Func<IEnumerable<TSource>, IEnumerable<TResult>> converter)
        {
            Index = source.Index;
            Size = source.Size;
            From = source.From;
            Count = source.Count;
            Pages = source.Pages;

            Items = new List<TResult>(converter(source.Items));
        }
        public int From { get; set; }
        public int Index { get; set; }
        public int Size { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public IList<TResult> Items { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
    }

    public static class Paginate
    {
        public static IPaginate<T> Empty<T>() => new Paginate<T>();
        public static IPaginate<TResult> From<TResult, TSourch>(
            IPaginate<TSourch> source, Func<IEnumerable<TSourch>, IEnumerable<TResult>> converter) => new Paginate<TSourch, TResult>(source, converter);
    }
}
