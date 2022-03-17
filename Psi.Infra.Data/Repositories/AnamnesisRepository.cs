using Microsoft.EntityFrameworkCore;
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

        public List<Anamnesis> ListAnamnesisByTenantId(int tenantId)
        {
            return _db.Anamnesis
                   .AsNoTracking()
                   .Where(x => x.TenantFk == tenantId)
                   .Include(x => x.AnamnesisTopics)
                   .ThenInclude(x => x.AnamnesisFields)
                   .ToList();
        }

        public void InsertTopic(AnamnesisTopic anamnesisTopic)
        {
            _db.AnamnesisTopics.SingleInsert(anamnesisTopic);
        }

        public void InsertField(AnamnesisField anamnesisField)
        {
            _db.AnamnesisFields.SingleInsert(anamnesisField);
        }
    }
}
