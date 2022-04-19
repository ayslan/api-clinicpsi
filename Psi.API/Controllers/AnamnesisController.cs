using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Psi.API.Base;
using Psi.API.Extensions;
using Psi.Domain.Interfaces.Services;

namespace Psi.API.Controllers
{
    public class AnamnesisController : BaseController
    {
        private readonly IAnamnesisService _anamnesisService;

        public AnamnesisController(IAnamnesisService anamnesisService)
        {
            _anamnesisService = anamnesisService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var tenantId = User.Identity.GetCurrentTenantId();
            var result = _anamnesisService.ListAnamnesisByTenantId(tenantId);

            return Response(result);
        }
    }
}
