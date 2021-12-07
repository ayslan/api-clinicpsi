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

        public TenantService(IMapper mapper, IGlobalUnitOfWork globalUoW)
        {
            _mapper = mapper;
            _globalUoW = globalUoW;
        }


        public TenantModel Create(TenantModel tenantModel)
        {
            var tenant = _mapper.Map<Tenant>(tenantModel);
            _globalUoW.TenantRepository.Insert(tenant);

            return _mapper.Map<TenantModel>(tenant);
        }

        public TenantUser AddUserToTenant(int tenantId, string userId)
        {
            var tenantUser = _globalUoW.TenantUserRepository.GetTenantUserByIds(tenantId, userId);

            if (tenantUser == null)
            {
                tenantUser.TenantFk = tenantId;
                tenantUser.UserFk = userId;

                _globalUoW.TenantUserRepository.Insert(tenantUser);
            }

            return null;
        }
    }
}
