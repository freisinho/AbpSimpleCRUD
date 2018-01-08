using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace AbpSimpleCRUD.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class AbpSimpleCRUDRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<AbpSimpleCRUDDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpSimpleCRUDRepositoryBase(IDbContextProvider<AbpSimpleCRUDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="AbpSimpleCRUDRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class AbpSimpleCRUDRepositoryBase<TEntity> : AbpSimpleCRUDRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpSimpleCRUDRepositoryBase(IDbContextProvider<AbpSimpleCRUDDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
