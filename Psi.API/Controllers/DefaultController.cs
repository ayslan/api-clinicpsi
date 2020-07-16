using Microsoft.AspNetCore.Mvc;

namespace Psi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "ok";
        }
    }
}