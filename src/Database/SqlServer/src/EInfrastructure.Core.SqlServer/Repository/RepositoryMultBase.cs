using System;
using EInfrastructure.Core.Config.Entities.Configuration;
using EInfrastructure.Core.Config.EntitiesExtensions;

namespace EInfrastructure.Core.SqlServer.Repository
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TDbContext"></typeparam>
    public class RepositoryBase<TEntity, T, TDbContext> : Common.RepositoryBase<TEntity, T>,
        IRepository<TEntity, T, TDbContext>
        where TEntity : Entity<T>, IAggregateRoot<T>
        where T : IComparable
        where TDbContext : IDbContext, IUnitOfWork
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="unitOfWork"></param>
        // ReSharper disable once SuspiciousTypeConversion.Global
        public RepositoryBase(IUnitOfWork<TDbContext> unitOfWork) : base(unitOfWork as IUnitOfWork)
        {
        }
    }
}
