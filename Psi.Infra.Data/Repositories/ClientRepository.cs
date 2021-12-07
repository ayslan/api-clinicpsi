using Microsoft.EntityFrameworkCore;
using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Psi.Infra.Data.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext contexto) : base(contexto) { }
    }
}
