using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.Web.Domain.Models.DTO;
using Klir.TechChallenge.Web.Domain.Models.Entity;
using Klir.TechChallenge.Web.Infrastructure.DataContext;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Features.Command.User
{
    public class LoginCommandHandler : ICommandHandler<LoginCommand, Response>
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<Persona> _userManager;
        private readonly SignInManager<Persona> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ILogger<LoginCommandHandler> _logger;

        public LoginCommandHandler(AppDbContext dbContext, UserManager<Persona> userManager,
            SignInManager<Persona> signInManager, RoleManager<Role> roleManager,
            ILogger<LoginCommandHandler> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<Response> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var result = await _signInManager.PasswordSignInAsync(request.Email, request.Password, true,  lockoutOnFailure: true);
            if (result.Succeeded)
            {
                _logger.LogInformation($"user with email logged in sucessfully");
                return new Response { Message = "success", Status = result.Succeeded };
            }
            return new Response { Message = "failed", Status = result.Succeeded };
        }
    }
}
