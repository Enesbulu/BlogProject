using BlogProject.Core.DataAccess.Base.Paging;
using BlogProject.Core.Entities.Base.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;

namespace BlogProject.Core.DataAccess.Base.Repositories
{
    public class EfRepositoryBase<TEntity, TEntityId, TContext> : IAsyncRepository<TEntity, TEntityId>
       where TEntity : Entity<TEntityId>
       where TEntityId : struct, IEquatable<TEntityId>
       where TContext : DbContext
    {
        protected readonly TContext Context;

        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> Query() => Context.Set<TEntity>();

        public async Task<TEntity> AddAsync(TEntity entity,CancellationToken cancellationToken)
        {
            entity.CreatedDate = DateTime.Now;
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities,CancellationToken cancellationToken)
        {
            foreach (var entity in entities)
                entity.CreatedDate = DateTime.Now;

            await Context.AddRangeAsync(entities);
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            if (predicate is not null)
                queryable = queryable.Where(predicate);

            return await queryable.AnyAsync(cancellationToken);
        }

        public async Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false,CancellationToken cancellationToken = default)
        {
            await SetEntityAsDeleteAsync(entity, permanent);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities, bool permanent = false,CancellationToken cancellationToken = default)
        {
            await SetEntityAsDeletedAsync(entities, permanent);
            await Context.SaveChangesAsync();
            return entities;
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include is not null)
                queryable = include(queryable);
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();

            return await queryable.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public async Task<IPaginate<TEntity>> GetListPaginateAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include is not null)
                queryable = include(queryable);
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            if (predicate is not null)
                queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).ToPaginateAsync(index, size, 0, cancellationToken);

            return await queryable.ToPaginateAsync(index, size, 0, cancellationToken);
        }
        public async Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> queryable = Query();
            if (!enableTracking)
                queryable = queryable.AsNoTracking();
            if (include is not null)
                queryable = include(queryable);
            if (withDeleted)
                queryable = queryable.IgnoreQueryFilters();
            if (predicate is not null)
                queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).ToListAsync(cancellationToken);

            return await queryable.ToListAsync(cancellationToken);
        }


        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken )
        {
            entity.ModifiedDate = DateTime.Now;
            Context.Update(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entities, CancellationToken cancellationToken)
        {
            foreach (var entity in entities)
                entity.ModifiedDate = DateTime.Now;

            Context.UpdateRange(entities);
            await Context.SaveChangesAsync();
            return entities;
        }

        protected async Task SetEntityAsDeleteAsync(TEntity entity, bool permanent)
        {
            if (!permanent)
            {
                CheckHasEntityHaveOneToOneRelation(entity, permanent);
                await SetEntityAsSoftDeletedAsync(entity);
            }
            else
            {
                Context.Remove(entity);

            }
        }

        protected void CheckHasEntityHaveOneToOneRelation(TEntity entity, bool permanent)
        {
            if (permanent)
            {
                bool hasEntityHaveOneToOneRelation = Context.Entry(entity).Metadata.GetForeignKeys()
                               .All(x => x.DependentToPrincipal?.IsCollection == true ||
                                    x.PrincipalToDependent?.IsCollection == true ||
                                    x.DependentToPrincipal?.ForeignKey.DeclaringEntityType.ClrType == entity.GetType()
                               );

                if (hasEntityHaveOneToOneRelation)
                    throw new InvalidOperationException(
                        "Entity has one-to-one relationship. Soft Delete causes problems if you try to create entry again by same foreign key."
                    );
            }

        }

        protected IQueryable<object> GetRelationLoaderQuery(IQueryable query, Type navigationPropertyType)
        {
            Type queryProviderType = query.Provider.GetType();
            MethodInfo createQueryMethod =
                queryProviderType
                    .GetMethods()
                    .First(m => m is { Name: nameof(query.Provider.CreateQuery), IsGenericMethod: true })
                    ?.MakeGenericMethod(navigationPropertyType)
                ?? throw new InvalidOperationException("CreateQuery<TElement> method is not found in IQueryProvider.");
            var queryProviderQuery =
                (IQueryable<object>)createQueryMethod.Invoke(query.Provider, parameters: new object[] { query.Expression })!;
            return queryProviderQuery.Where(x => !((IHasTimeStamps)x).DeletedDate.HasValue);
        }

        private async Task SetEntityAsSoftDeletedAsync(IHasTimeStamps hasTimeStamps)
        {
            if (hasTimeStamps.DeletedDate.HasValue)
                return;

            hasTimeStamps.DeletedDate = DateTime.Now;
            hasTimeStamps.isDeleted = true;

            var navigations = Context
           .Entry(hasTimeStamps)
           .Metadata.GetNavigations()
           .Where(x => x is { IsOnDependent: false, ForeignKey.DeleteBehavior: DeleteBehavior.ClientCascade or DeleteBehavior.Cascade })
           .ToList();

            foreach (INavigation? navigation in navigations)
            {
                if (navigation.TargetEntityType.IsOwned())
                    continue;
                if (navigation.PropertyInfo == null)
                    continue;

                object? navValue = navigation.PropertyInfo.GetValue(hasTimeStamps);
                if (navigation.IsCollection)
                {
                    if (navValue == null)
                    {
                        IQueryable query = Context.Entry(hasTimeStamps).Collection(navigation.PropertyInfo.Name).Query();
                        navValue = await GetRelationLoaderQuery(query, navigationPropertyType: navigation.PropertyInfo.GetType()).ToListAsync();
                        if (navValue == null)
                            continue;
                    }

                    foreach (IHasTimeStamps navValueItem in (IEnumerable)navValue)
                        await SetEntityAsSoftDeletedAsync(navValueItem);
                }
                else
                {
                    if (navValue == null)
                    {
                        IQueryable query = Context.Entry(hasTimeStamps).Reference(navigation.PropertyInfo.Name).Query();
                        navValue = await GetRelationLoaderQuery(query, navigationPropertyType: navigation.PropertyInfo.GetType())
                            .FirstOrDefaultAsync();
                        if (navValue == null)
                            continue;
                    }

                    await SetEntityAsSoftDeletedAsync((IHasTimeStamps)navValue);
                }
            }

            Context.Update(hasTimeStamps);
        }

        protected async Task SetEntityAsDeletedAsync(IEnumerable<TEntity> entities, bool permanent)
        {
            foreach (TEntity entity in entities)
                await SetEntityAsDeleteAsync(entity, permanent);
        }


    }
}
