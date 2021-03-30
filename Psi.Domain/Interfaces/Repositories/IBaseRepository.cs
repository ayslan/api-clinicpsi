using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        Task UpdateAsync(TEntity obj);
        void Delete(int id);
        Task DeleteAsync(int id);
        IList<TEntity> Select();
        TEntity Select(int id);
        Task<TEntity> SelectAsync(int id);
        Task<TEntity> SelectAsync(string id);
        List<TEntity> ToList();
    }
}
