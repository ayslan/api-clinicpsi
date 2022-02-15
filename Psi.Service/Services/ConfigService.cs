using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Service.Services
{
    public class ConfigService : IConfigService
    {
        private readonly IGlobalUnitOfWork _globalUoW;

        public ConfigService(IGlobalUnitOfWork globalUoW)
        {
            _globalUoW = globalUoW;
        }

        public Insurance AddInsurance(Insurance insurance)
        {
            _globalUoW.InsuranceRepository.Insert(insurance);

            return insurance;
        }

        public Insurance GetInsurance(int id)
        {
            return _globalUoW.InsuranceRepository.Find(id);
        }

        public List<Insurance> ListInsurance(int tenantId)
        {
            return _globalUoW.InsuranceRepository.ListByTenantId(tenantId);
        }

        public void DeleteInsurance(int id)
        {
            _globalUoW.InsuranceRepository.Delete(id);
        }
    }
}
