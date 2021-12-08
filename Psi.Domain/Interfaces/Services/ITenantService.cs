using Psi.Domain.Entities;
using Psi.Domain.Models.Tenant;

namespace Psi.Domain.Interfaces.Services
{
    public interface ITenantService
    {
        TenantModel Create(string userId, string name = null);
        TenantUser AddUserToTenant(int tenantId, string userId);
    }
}
