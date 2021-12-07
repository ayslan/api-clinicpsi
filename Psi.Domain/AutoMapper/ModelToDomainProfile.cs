using AutoMapper;
using Psi.Domain.Entities;
using Psi.Domain.Models.Client;
using Psi.Domain.Models.Tenant;
using Psi.Domain.Models.User;

namespace Psi.Domain.AutoMapper
{
    public class ModelToDomainProfile : Profile
    {
        public ModelToDomainProfile()
        {
            CreateMap<ApplicationUserModel, ApplicationUser>();
            CreateMap<ClientModel, ApplicationUser>();
            CreateMap<ClientModel, Client>();
            CreateMap<TenantModel, Tenant>();
        }
    }
}
