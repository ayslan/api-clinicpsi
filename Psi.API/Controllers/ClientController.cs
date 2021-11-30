using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Psi.API.Base;
using Psi.Domain.Entities;
using Psi.Domain.Enums;
using Psi.Domain.Interfaces.Services;
using Psi.Domain.Models.Client;
using Psi.Infra.CrossCutting.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psi.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ClientController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IClientService _clientService;

        public ClientController(UserManager<ApplicationUser> userManager, IMapper mapper, IClientService clientService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _clientService = clientService;
        }

        //[HttpGet]
        //[AllowAnonymous]
        //public async Task<IActionResult> List() => Response(await _clientService.ListAsync());
    }
}
