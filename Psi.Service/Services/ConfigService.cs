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
    }
}
