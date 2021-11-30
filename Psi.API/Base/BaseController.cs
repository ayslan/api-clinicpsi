using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Psi.API.Base
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BaseController : Controller
    {
        protected bool IsList(object o)
        {
            if (o == null) return false;
            return o is IList &&
                   o.GetType().IsGenericType &&
                   o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }

        protected IActionResult ResponseBadRequest(object result)
        {
            var type = result.GetType();
            var dicResult = new Dictionary<string, string>();

            if (IsList(result))
            {
                var count = 1;
                var listResult = result as List<string>;
                dicResult = listResult.ToDictionary(x => count++.ToString(), x => x);
            }
            else
            {
                dicResult = result as Dictionary<string, string>;
            }

            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;

            return new JsonResult(new
            {
                success = false,
                errors = dicResult.Select(a => new { ErrorCode = a.Key, Message = a.Value })
            });
        }

        protected IActionResult OkResponse(object result = null, dynamic info = null)
        {
            return Ok(new
            {
                success = true,
                data = result,
                info
            });
        }

        protected IActionResult OkResponse<T>(ResponseResult<T> result)
        {
            return Ok(result);
        }

        protected new IActionResult Response(object result = null, dynamic info = null)
        {
            if (result != null)
            {
                if (result is Dictionary<string, string>)
                {
                    return ResponseBadRequest(result);
                }

                return OkResponse(result);
            }

            var random = new Random();
            var erros = ModelState.Values.SelectMany(x => x.Errors).ToDictionary(x => random.Next(1, 2000).ToString(), x => x.ErrorMessage);
            return ResponseBadRequest(erros);
        }
    }
}
