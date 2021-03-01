using Microsoft.AspNetCore.Mvc;
using Psi.Domain.Models;
using System;
using System.Linq;

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

        [HttpPost]
        public IActionResult Post([FromBody] CreateTesteModel model)
        {
            return Ok(model);
        }

        //    [HttpPut]
        //    public IActionResult Put([FromBody] UpdateTesteModel model)
        //    {
        //        //if (!ModelState.IsValid)
        //        //{
        //        //    var random = new Random();
        //        //    var erros = ModelState.Values.SelectMany(x => x.Errors).ToDictionary(x => random.Next(1, 2000).ToString(), x => x.ErrorMessage);

        //        //    return BadRequest(ModelState.ValidationState);
        //        //}

        //        return Ok(model);
        //    }
    }
}