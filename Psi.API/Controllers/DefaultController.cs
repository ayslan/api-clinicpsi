using IdentityServer4;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Psi.API.Base;
using Psi.Domain.Models;
using System;
using System.Linq;

namespace Psi.API.Controllers
{
    public class DefaultController : BaseController
    {
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] CreateTesteModel model)
        {
            return Ok(model);
        }
    }
}