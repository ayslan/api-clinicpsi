using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Repositories
{
    public interface IGlobalUnitOfWork
    {
        IClientRepository ClientRepository { get; set; }
    }
}
