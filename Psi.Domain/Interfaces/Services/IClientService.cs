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
        List<ClientModel> List();
        ClientModel GetByUserId(int id);
        ClientModel Register(ClientModel clientModel);
    }
}
