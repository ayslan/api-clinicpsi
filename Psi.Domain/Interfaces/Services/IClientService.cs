using Psi.Domain.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Services
{
    public interface IClientService
    {
        List<ClientModel> List(int tenantId);
        ClientModel GetByUserId(int id);
        ClientModel Register(ClientModelRequest clientModel);
        ClientModel Update(int id, ClientModelRequest clientModel);
        int DeleteById(int id);
    }
}
