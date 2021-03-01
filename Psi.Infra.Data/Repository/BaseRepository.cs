using Psi.Domain.Entities;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TKeyType> where TEntity : BaseEntity<TKeyType, TEntity>
    {
        protected readonly AppDBContext _db;

        public BaseRepository(AppDBContext dbContext)
        {
            _db = dbContext;
        }

        protected virtual void Insert(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        protected virtual void Update(TEntity obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public async Task UpdateAsync(TEntity obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        protected virtual void Delete(int id)
        {
            _db.Set<TEntity>().Remove(Select(id));
            _db.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            _db.Set<TEntity>().Remove(Select(id));
            await _db.SaveChangesAsync();
        }

        public async Task<TEntity> SelectAsync(int id) =>
            await _db.Set<TEntity>().FindAsync(id);

        protected virtual TEntity Select(int id) =>
            _db.Set<TEntity>().Find(id);

        public List<TEntity> ToList() =>
           _db.Set<TEntity>().ToList();
    }
}
