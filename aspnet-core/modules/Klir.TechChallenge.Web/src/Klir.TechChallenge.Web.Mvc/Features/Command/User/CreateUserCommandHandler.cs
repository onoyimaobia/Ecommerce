using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.Web.Domain.Models;
using Klir.TechChallenge.Web.Domain.Models.DTO;
using Klir.TechChallenge.Web.Domain.Models.Entity;
using Klir.TechChallenge.Web.Infrastructure.DataContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Features.Command.User
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Response>
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<Persona> _userManager;
        private readonly SignInManager<Persona> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ILogger<LoginCommandHandler> _logger;

        public CreateUserCommandHandler(AppDbContext dbContext, UserManager<Persona> userManager,
            SignInManager<Persona> signInManager, RoleManager<Role> roleManager,
            ILogger<LoginCommandHandler> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<Response> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var account = await _userManager.Users.FirstOrDefaultAsync(c => c.Email == request.Payload.Email, cancellationToken: cancellationToken);
            if (account != null) return new Response {Status = false, Message = "User Already Has An Account" };

            var person = new Persona { FirstName = request.Payload.FirstName, LastName = request.Payload.LastName, Email = request.Payload.Email, PhoneNumber = request.Payload.PhoneNumber, UserName = request.Payload.Email };

           
            var result = await _userManager.CreateAsync(person, request.Payload.Password);
            if (!result.Succeeded)
            {
                _logger.LogError("User Registration failed", result);
                var t = result.Errors.FirstOrDefault().Description;
                return new Response { Status= result.Succeeded, Message = result.Errors?.FirstOrDefault()?.Description };
            }
            //add user to role
            await _userManager.AddToRoleAsync(person, RoleConstants.user);
            _logger.LogInformation("User Registered Successfully");
            await _signInManager.SignInAsync(person, isPersistent: false);
            _logger.LogInformation("User logged in Successfully");

            // _ = mediator.Publish(new PersonRegisteredNotification { Person = person, WasCreatedBySuperAdmin = isSuperAdmin, DefaultPassword = isSuperAdmin ? payload.Password : null });

            return new Response {Message = "Sucess", Status = true };

        }
    }
}
