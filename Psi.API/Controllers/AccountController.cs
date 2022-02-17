using AutoMapper;
using IdentityServer4;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Psi.API.Base;
using Psi.API.Data;
using Psi.Domain.Entities;
using Psi.Domain.Interfaces.Services;
using Psi.Domain.Models.User;
using Psi.Infra.CrossCutting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Psi.API.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITenantService _tenantService;

        public AccountController(UserManager<ApplicationUser> userManager, ITenantService tenantService)
        {
            _userManager = userManager;
            _tenantService = tenantService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post(RegisterUserModel model)
        {
            if (!ModelState.IsValid)
            {
                return Response();
            }

            var user = new ApplicationUser
            {
                Name = model.Name,
                Email = model.Email,
                UserName = model.Email,
                LockoutEnabled = false,
                CreationDateUtc = DateTime.UtcNow,
                EmailConfirmed = true
            };

            try
            {
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _tenantService.Create(user.Id);
                    return OkResponse();
                }

                if (result.Errors.Any(x => x.Code == "DuplicateUserName"))
                {
                    return Response(result.Errors.ToDictionary(x => x.Code, x => "Email já cadastrado!"));
                }

                return Response(result.Errors.ToDictionary(x => x.Code, x => x.Description));
            }
            catch (Exception ex)
            {
                return Response();
            }
        }
    }
}
