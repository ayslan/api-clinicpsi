﻿using AutoMapper;
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

        public List<ClientModel> List(int tenantId)
        {
            return _mapper.Map<List<ClientModel>>(_globalUoW.ClientRepository.ListByTenantId(tenantId));
        }

        public ClientModel GetByUserId(int id) => _mapper.Map<ClientModel>(_globalUoW.ClientRepository.Find(id));

        public ClientModel Register(ClientModelRequest clientModel)
        {
            var client = _mapper.Map<Client>(clientModel);
            _globalUoW.ClientRepository.Insert(client);

            return _mapper.Map<ClientModel>(client); ;
        }

        public ClientModel Update(int id, ClientModelRequest clientModel)
        {
            var client = _globalUoW.ClientRepository.Find(id);
            _mapper.Map(clientModel, client);

            _globalUoW.ClientRepository.Update(client);
            _globalUoW.Commit();

            return _mapper.Map<ClientModel>(client); ;
        }

        public int DeleteById(int id)
        {
            return _globalUoW.ClientRepository.DeleteById(id);
        }
    }
}
