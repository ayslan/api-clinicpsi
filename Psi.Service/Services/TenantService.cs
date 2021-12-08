using AutoMapper;
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

        private const string TENANT_NAME_DEFAULT = "Minha Clínica";

        public TenantService(IMapper mapper, IGlobalUnitOfWork globalUoW)
        {
            _mapper = mapper;
            _globalUoW = globalUoW;
        }


        public TenantModel Create(string userId, string name = null)
        {
            var tenant = new Tenant
            {
                Name = name ?? TENANT_NAME_DEFAULT
            };

            _globalUoW.TenantRepository.Insert(tenant);

            AddUserToTenant(tenant.TenantId, userId);

            return _mapper.Map<TenantModel>(tenant);
        }

        public TenantUser AddUserToTenant(int tenantId, string userId)
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
            }

            return null;
        }
    }
}
