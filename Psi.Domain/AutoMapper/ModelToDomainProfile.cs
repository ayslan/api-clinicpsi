using AutoMapper;
using Newtonsoft.Json;
using Psi.Domain.Entities;
using Psi.Domain.Models.Anamnesis;
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
            CreateMap<ClientModelRequest, Client>();
            CreateMap<TenantModel, Tenant>();

            CreateMap<AnamnesisModel, Anamnesis>();
            CreateMap<AnamnesisTopicModel, AnamnesisTopic>();
            CreateMap<AnamnesisFieldModel, AnamnesisField>()
                .ForMember(d => d.Info, o => o?.MapFrom(s => s.Options == null ? null : JsonConvert.SerializeObject(s.Options)));
        }
    }
}
