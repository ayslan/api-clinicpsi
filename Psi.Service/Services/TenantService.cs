using AutoMapper;
using Psi.Domain.Interfaces.Repositories;
using Psi.Domain.Interfaces.Services;
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


    }
}
