using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Psi.API.Base;
using Psi.API.Extensions;
using Psi.Domain.Interfaces.Services;
using Psi.Domain.Models.Client;
using System;

namespace Psi.API.Controllers
{
    public class ClientsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IClientService _clientService;

        public ClientsController(IMapper mapper, IClientService clientService)
        {
            _mapper = mapper;
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var tenantId = User.Identity.GetCurrentTenantId();

            return Response(_clientService.List(tenantId));
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var tenantId = User.Identity.GetCurrentTenantId();
            var client = _clientService.GetByUserId(id);

            if (tenantId != client.TenantFk)
                return Unauthorized();

            return Response(client);
        }

        [HttpPost]
        public IActionResult Register(ClientModel clientModel)
        {
            clientModel.TenantFk = User.Identity.GetCurrentTenantId();
            clientModel.CreationDateUtc = DateTime.UtcNow;

            var result = _clientService.Register(clientModel);

            return Response(result);
        }
    }
}
