using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Repository;
using Psi.Domain.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Repositories
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        List<Client> List();
        Client GetById(int id);
    }
}
