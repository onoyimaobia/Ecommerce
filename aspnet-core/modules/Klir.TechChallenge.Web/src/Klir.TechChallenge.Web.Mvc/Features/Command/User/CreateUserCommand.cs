using Klir.TechChallenge.SharedLib.Shared;
using Klir.TechChallenge.Web.Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Features.Command.User
{
    public class CreateUserCommand: ICommand<Response>
    {
        public CreateUserCommand(CreateUserPayload payload)
        {
            Payload = payload;
        }
        public CreateUserPayload Payload { get; set; }
    }
}
