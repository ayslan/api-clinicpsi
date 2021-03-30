﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Psi.API.Base;
using Psi.Domain.Entities;
using Psi.Domain.Enums;
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

        public ClientController(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(ClientModel model)
        {
            if (!ModelState.IsValid)
            {
                return Response();
            }

            var user = _mapper.Map<ApplicationUser>(model);
            user.UserName = model.Phone.OnlyDigits();
            user.Type = UserTypeEnum.Client;
            user.CreationDateUtc = DateTime.UtcNow; 
            user.LockoutEnabled = false;

            try
            {
                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    var clientData = _mapper.Map<ClientUserData>(model);
                    clientData.UserFk = user.Id;



                    return OkResponse(user);
                }

                return Response(result.Errors.ToDictionary(x => x.Code, x => x.Description));
            }
            catch
            {
                return Response();
            }

            return View();
        }
    }
}