using AutoMapper;
using Psi.Domain.Entities;
using Psi.Domain.Models.Client;
using Psi.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.AutoMapper
{
    public class ModelToDomainProfile : Profile
    {
        public ModelToDomainProfile()
        {
            CreateMap<ApplicationUserModel, ApplicationUser>();
            CreateMap<RegisterClientModel, ApplicationUser>();
            CreateMap<RegisterClientModel, ClientUserData>();

        }
    }
}
