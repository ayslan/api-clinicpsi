using Psi.Domain.Interfaces.Repository;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _db;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            if (dbContext != null)
                _db = dbContext;
        }

        public void Insert(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
        }

        public async Task UpdateAsync(TEntity obj)
        {
            _db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _db.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _db.Set<TEntity>().Remove(Find(id));
            _db.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            _db.Set<TEntity>().Remove(Find(id));
            await _db.SaveChangesAsync();
        }

        public TEntity Find(int id) =>
            _db.Set<TEntity>().Find(id);

        public async Task<TEntity> FindAsync(int id) =>
           await _db.Set<TEntity>().FindAsync(id);

        public async Task<TEntity> FindAsync(string id) =>
         await _db.Set<TEntity>().FindAsync(id);

        public IList<TEntity> List() =>
            _db.Set<TEntity>().ToList();
    }
}
