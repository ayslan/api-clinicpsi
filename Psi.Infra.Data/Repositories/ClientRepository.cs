using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repositories;
using Psi.Domain.Models.Client;
using Psi.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Infra.Data.Repositories
{
    public class ClientRepository : BaseRepository<ClientUserData>, IClientRepository
    {
        private readonly IMapper _mapper;

        public ClientRepository(ApplicationDbContext contexto, IMapper mapper) : base(contexto)
        {
            _mapper = mapper;
        }

        public async Task<List<ClientModel>> List()
        {
            var users = await _db.Users.Include(x => x.ClientUserData).AsNoTracking().ToListAsync();
            var clientsModel = new List<ClientModel>();

            users.ForEach(user => clientsModel.Add(ConvertUserToClientModel(user)));

            return clientsModel;
        }

        public async Task<ClientModel> GetByUserId(string id)
        {
            var user = await _db.Users.Include(x => x.ClientUserData).AsNoTracking().FirstAsync(x => x.Id == id);
            var clientModel = ConvertUserToClientModel(user);

            return clientModel;
        }

        //Utils
        private ClientModel ConvertUserToClientModel(ApplicationUser user)
        {
            var clientModel = _mapper.Map<ClientModel>(user);
            clientModel.Code = user.ClientUserData.Code;
            clientModel.RG = user.ClientUserData.RG;
            clientModel.BirthDate = user.ClientUserData.BirthDate;
            clientModel.MaritalStatus = user.ClientUserData.MaritalStatus;
            clientModel.Status = user.ClientUserData.Status;
            clientModel.ServiceModality = user.ClientUserData.ServiceModality;
            clientModel.EducationLevel = user.ClientUserData.EducationLevel;
            clientModel.Profession = user.ClientUserData.Profession;
            clientModel.Religion = user.ClientUserData.Religion;
            clientModel.WithWhoResides = user.ClientUserData.WithWhoResides;
            clientModel.ValueService = user.ClientUserData.ValueService;

            return clientModel;
        }
    }
}
