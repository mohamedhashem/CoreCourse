using Contractor;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class RepoBase<T> : IRepoBase<T> where T : class
    {
        protected RepoContext RepoContext;
        public RepoBase(RepoContext repoContext)
        {
            RepoContext = repoContext;
        }
        public void Create(T entity) => RepoContext.Set<T>().Add(entity);
        public void Delete(T entity) => RepoContext.Set<T>().Remove(entity);
        public void Update(T entity) => RepoContext.Set<T>().Update(entity);

        /// <summary>
        /// TrackChanges : If Fasle Use AsNoTracking
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? RepoContext.Set<T>().AsNoTracking() : RepoContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ? RepoContext.Set<T>().Where(expression).AsNoTracking() : RepoContext.Set<T>().Where(expression);


    }
}
