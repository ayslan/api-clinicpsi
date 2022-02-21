using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Psi.API.Base;
using Psi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psi.API.Controllers
{
    public class SystemController : BaseController
    {
        private readonly ISystemService _systemService;

        public SystemController(ISystemService systemService)
        {
            _systemService = systemService;
        }

        [HttpGet("cities")]
        [AllowAnonymous]
        public IActionResult ListCities()
        {
            return Response(_systemService.ListCities());
        }

        [HttpGet("countries")]
        [AllowAnonymous]
        public IActionResult ListCountries()
        {
            return Response(_systemService.ListCountries());
        }
    }
}
