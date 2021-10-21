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
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext contexto) : base(contexto)
        {

        }

        public async Task<List<ApplicationUser>> ListAsync()
        {
            var users = await _db.Users.Include(x => x.ClientUserData).AsNoTracking().ToListAsync();

            return users;
        }

        public async Task<ApplicationUser> GetByUserIdAsync(string id)
        {
            return await _db.Users.Include(x => x.ClientUserData).AsNoTracking().FirstAsync(x => x.Id == id);
        }
    }
}
