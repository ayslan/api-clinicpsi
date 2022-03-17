using Psi.Domain.Models.Anamnesis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Services
{
    public interface IAnamnesisService
    {
        List<AnamnesisModel> ListAnamnesisByTenantId(int tenantId);
        void CreateAnamnesis();
    }
}
