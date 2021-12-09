using Psi.Domain.Entities;
using Psi.Domain.Models.Tenant;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Services
{
    public interface ITenantService
    {
        Task<TenantModel> Create(string userId, string name = null);
        Task<TenantUser> AddUserToTenant(int tenantId, string userId);
    }
}
