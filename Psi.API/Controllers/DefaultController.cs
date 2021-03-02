using IdentityServer4;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Psi.Domain.Models;
using System;
using System.Linq;

namespace Psi.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(IdentityServerConstants.LocalApi.PolicyName)]
    public class DefaultController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Teste()
        {
            return Ok("teste ok");
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post([FromBody] CreateTesteModel model)
        {
            return Ok(model);
        }
    }
}