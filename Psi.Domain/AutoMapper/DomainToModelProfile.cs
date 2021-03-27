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
    public class DomainToModelProfile : Profile
    {
        public DomainToModelProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserModel>();
            CreateMap<ApplicationUser, RegisterClientModel>();
            CreateMap<ClientUserData, RegisterClientModel>();
        }
    }
}
