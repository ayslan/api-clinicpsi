using Psi.Domain.Entities;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Psi.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TKeyType> where TEntity : BaseEntity<TKeyType, TEntity>
    {
        protected readonly AppDBContext _dbContext;

        public BaseRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected virtual void Insert(TEntity obj)
        {
            _dbContext.Set<TEntity>().Add(obj);
            _dbContext.SaveChanges();
        }

        protected virtual void Update(TEntity obj)
        {
            _dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
        }

        protected virtual void Delete(int id)
        {
            _dbContext.Set<TEntity>().Remove(Select(id));
            _dbContext.SaveChanges();
        }

        protected virtual IList<TEntity> Select() =>
            _dbContext.Set<TEntity>().ToList();

        protected virtual TEntity Select(int id) =>
            _dbContext.Set<TEntity>().Find(id);
    }
}
