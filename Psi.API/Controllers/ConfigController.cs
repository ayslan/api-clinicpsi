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
    [Route("/api")]
    public class ConfigController : BaseController
    {
        public readonly IConfigService _configService;

        public ConfigController(IConfigService configService)
        {
            _configService = configService;
        }
    }
}
