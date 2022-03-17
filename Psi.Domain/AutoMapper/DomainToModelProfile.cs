using AutoMapper;
using Newtonsoft.Json;
using Psi.Domain.Entities;
using Psi.Domain.Models.Anamnesis;
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

            CreateMap<Anamnesis, AnamnesisModel>();
            CreateMap<AnamnesisTopic, AnamnesisTopicModel>();
            CreateMap<AnamnesisField, AnamnesisFieldModel>()
                .ForMember(d => d.Options, o => o?.MapFrom(s => JsonConvert.DeserializeObject<string[]>(s.Info)));
        }
    }
}
