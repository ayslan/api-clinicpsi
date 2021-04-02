using Psi.Domain.Interfaces.Repositories;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.Data.Repositories
{
    public class GlobalUnitOfWork : IGlobalUnitOfWork
    {
        private ApplicationDbContext _db;
        public virtual IClientRepository ClientRepository { get; set; }

        public GlobalUnitOfWork()
        {
            _db = new ApplicationDbContext();
            loadAllRepositories(_db);
        }

        private void loadAllRepositories(ApplicationDbContext db)
        {
            ClientRepository = new ClientRepository(db);
        }

        public GlobalUnitOfWork InNewContext()
        {
            _db = new ApplicationDbContext();
            loadAllRepositories(_db);

            return this;
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public virtual async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }

    }
}
