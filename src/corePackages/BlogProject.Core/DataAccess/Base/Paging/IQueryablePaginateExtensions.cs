using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace BlogProject.Core.DataAccess.Base.Paging
{
    public static class IQueryablePaginateExtensions
    {
        public static async Task<IPaginate<T>> ToPaginateAsync<T>(this IQueryable<T> source, int index, int size, int from = 0, CancellationToken cancellationToken = default)
        {
            if (from > index)
            {
                throw new ArgumentException($"index: {index} cannot be less than from: {from}");
            }

            int count = await source.CountAsync(cancellationToken).ConfigureAwait(false);
            List<T> items = await source.Skip((index - from) * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);

            Paginate<T> List = new()
            {
                Index = index,
                Size = size,
                From = from,
                Count = count,
                Items = items,
                Pages = (int)Math.Ceiling(count / (double)from)
            };
            return List;
        }

        public static IPaginate<T> ToPaginate<T>(this IQueryable<T> source, int index, int size, int from = 0)
        {
            if (from > index)
            {
                throw new ArgumentException($"index: {index} cannot be less than from: {from}");
            }

            int count =  source.Count();
            List<T> items =  source.Skip((index - from) * size).Take(size).ToList();

            Paginate<T> List = new()
            {
                Index = index,
                Size = size,
                From = from,
                Count = count,
                Items = items,
                Pages = (int)Math.Ceiling(count / (double)from)
            };
            return List;
        }
    }
}
