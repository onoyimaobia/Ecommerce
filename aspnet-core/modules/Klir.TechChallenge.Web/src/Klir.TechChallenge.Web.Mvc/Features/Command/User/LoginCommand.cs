using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.Web.Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Features.Command.User
{
    public class LoginCommand: ICommand<Response>
    {
        public LoginCommand(string email, string password)
        {
            Password = password;
            Email = email;
        }
        public string Email { get;}
        public string Password { get; }
    }
}
