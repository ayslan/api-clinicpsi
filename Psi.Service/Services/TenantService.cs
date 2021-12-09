using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Domain.Interfaces.Services;
using Psi.Domain.Models.Tenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Service.Services
{
    public class TenantService : ITenantService
    {
        private readonly IMapper _mapper;
        private readonly IGlobalUnitOfWork _globalUoW;
        private readonly UserManager<ApplicationUser> _userManager;

        private const string TENANT_NAME_DEFAULT = "Minha Clínica";

        public TenantService(IMapper mapper, IGlobalUnitOfWork globalUoW, UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _globalUoW = globalUoW;
            _userManager = userManager;
        }


        public async Task<TenantModel> Create(string userId, string name = null)
        {
            var tenant = new Tenant
            {
                Name = name ?? TENANT_NAME_DEFAULT
            };

            _globalUoW.TenantRepository.Insert(tenant);

            await AddUserToTenant(tenant.TenantId, userId);

            return _mapper.Map<TenantModel>(tenant);
        }

        public async Task<TenantUser> AddUserToTenant(int tenantId, string userId)
        {
            var tenantUser = _globalUoW.TenantUserRepository.GetTenantUserByIds(tenantId, userId);

            if (tenantUser == null)
            {
                tenantUser = new TenantUser
                {
                    TenantFk = tenantId,
                    UserFk = userId
                };

                _globalUoW.TenantUserRepository.Insert(tenantUser);

                var user = await _userManager.FindByIdAsync(userId);
                user.CurrentTenantFk = tenantId;
                await _userManager.UpdateAsync(user);
            }

            return null;
        }
    }
}
