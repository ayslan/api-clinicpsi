using Psi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psi.Domain.Interfaces.Services
{
    public interface IConfigService
    {
        Insurance AddInsurance(Insurance insurance);
        Insurance GetInsurance(int id);
        List<Insurance> ListInsurance(int tenantId);
        void DeleteInsurance(int id);
    }
}
