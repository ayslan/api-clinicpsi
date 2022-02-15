using Microsoft.AspNetCore.Mvc;
using Psi.API.Base;
using Psi.API.Extensions;
using Psi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psi.API.Controllers
{
    public class ConfigController : BaseController
    {
        public readonly IConfigService _configService;

        public ConfigController(IConfigService configService)
        {
            _configService = configService;
        }

        [HttpGet("insurace")]
        public IActionResult ListInsurance()
        {
            var tenantId = User.Identity.GetCurrentTenantId();

            return Response(_configService.ListInsurance(tenantId));
        }
    }
}
