using AutoMapper;
using Psi.Domain.Entities;
using Psi.Domain.Models.Client;
using Psi.Domain.Models.Tenant;
using Psi.Domain.Models.User;

namespace Psi.Domain.AutoMapper
{
    public class DomainToModelProfile : Profile
    {
        public DomainToModelProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserModel>();
            CreateMap<ApplicationUser, ClientModel>();
            CreateMap<Client, ClientModel>();
            CreateMap<Tenant, TenantModel>();
        }
    }
}
