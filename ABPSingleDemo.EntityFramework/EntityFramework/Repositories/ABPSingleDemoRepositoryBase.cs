using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPSingleDemo.EntityFramework.Repositories
{
    public abstract class ABPSingleDemoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPSingleDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPSingleDemoRepositoryBase(IDbContextProvider<ABPSingleDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPSingleDemoRepositoryBase<TEntity> : ABPSingleDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPSingleDemoRepositoryBase(IDbContextProvider<ABPSingleDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
