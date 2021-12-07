using Psi.Domain.Entities;
using Psi.Domain.Models.Tenant;

namespace Psi.Domain.Interfaces.Services
{
    public interface ITenantService
    {
        TenantModel Create(TenantModel tenantModel);
        TenantUser AddUserToTenant(int tenantId, string userId);
    }
}
