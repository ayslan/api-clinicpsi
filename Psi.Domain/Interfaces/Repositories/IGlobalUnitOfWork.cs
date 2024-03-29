﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Repositories
{
    public interface IGlobalUnitOfWork
    {
        IClientRepository ClientRepository { get; set; }
        ITenantRepository TenantRepository { get; set; }
        ITenantUserRepository TenantUserRepository { get; set; }
        IInsuranceRepository InsuranceRepository { get; set; }
        ICityRepository CityRepository { get; set; }
        ICountryRepository CountryRepository { get; set; }
        IAnamnesisRepository AnamnesisRepository { get; set; }
        void Commit();
        Task CommitAsync();
    }
}
