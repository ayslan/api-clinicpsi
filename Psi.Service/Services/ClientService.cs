using AutoMapper;
using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Domain.Interfaces.Services;
using Psi.Domain.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Service.Services
{
    public class ClientService : IClientService
    {
        private readonly IMapper _mapper;
        private readonly IGlobalUnitOfWork _globalUoW;

        public ClientService(IMapper mapper, IGlobalUnitOfWork globalUoW)
        {
            _mapper = mapper;
            _globalUoW = globalUoW;
        }

        //public async Task<List<ClientModel>> ListAsync()
        //{
        //    var users = await _globalUoW.ClientRepository.ListAsync();
        //    var clientsModel = new List<ClientModel>();
        //    users.ForEach(user => clientsModel.Add(ConvertUserToClientModel(user)));

        //    return clientsModel;
        //}

        //public async Task<ClientModel> GetByUserId(string id)
        //{
        //    var user = await _globalUoW.ClientRepository.GetByUserIdAsync(id);
        //    var clientModel = ConvertUserToClientModel(user);

        //    return clientModel;
        //}

        //Utils
        //private ClientModel ConvertUserToClientModel(ApplicationUser user)
        //{
        //    var clientModel = _mapper.Map<ClientModel>(user);

        //    if (user.ClientUserData != null)
        //    {
        //        clientModel.Code = user.ClientUserData.Code;
        //        clientModel.RG = user.ClientUserData.RG;
        //        clientModel.BirthDate = user.ClientUserData.BirthDate;
        //        clientModel.MaritalStatus = user.ClientUserData.MaritalStatus;
        //        clientModel.Status = user.ClientUserData.Status;
        //        clientModel.ServiceModality = user.ClientUserData.ServiceModality;
        //        clientModel.EducationLevel = user.ClientUserData.EducationLevel;
        //        clientModel.Profession = user.ClientUserData.Profession;
        //        clientModel.Religion = user.ClientUserData.Religion;
        //        clientModel.WithWhoResides = user.ClientUserData.WithWhoResides;
        //        clientModel.ValueService = user.ClientUserData.ValueService;
        //    }

        //    return clientModel;
        //}
    }
}
