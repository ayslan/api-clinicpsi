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
        public virtual ITenantRepository TenantRepository { get; set; }
        public virtual ITenantUserRepository TenantUserRepository { get; set; }
        public virtual IInsuranceRepository InsuranceRepository { get; set; }
        public virtual ICityRepository CityRepository { get; set; }

        public GlobalUnitOfWork()
        {
            _db = new ApplicationDbContext();
            loadAllRepositories(_db);
        }

        private void loadAllRepositories(ApplicationDbContext db)
        {
            ClientRepository = new ClientRepository(db);
            TenantRepository = new TenantRepository(db);
            TenantUserRepository = new TenantUserRepository(db);
            InsuranceRepository = new InsuranceRepository(db);
            CityRepository = new CityRepository(db);
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
