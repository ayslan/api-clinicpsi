using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.Data.Repositories
{
    public class AnamnesisRepository : BaseRepository<Anamnesis>, IAnamnesisRepository
    {
        public AnamnesisRepository(ApplicationDbContext dbContext) : base(dbContext) { }


    }
}
