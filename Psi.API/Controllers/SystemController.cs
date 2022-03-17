using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        [HttpGet("info")]
        [AllowAnonymous]
        public IActionResult SystemInfo()
        {
            var teste = new string[] { "opcao1", "opcao2", "opcao3" };
            var strTeste = JsonConvert.SerializeObject(teste);

            var novo = JsonConvert.DeserializeObject<string[]>("[\"opcao1\",\"opcao2\",\"opcao3\"]");

            var result = new
            {
                teste = JsonConvert.SerializeObject(teste)
            };

            return Response(result);
        }
    }
}
