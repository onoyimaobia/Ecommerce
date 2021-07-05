using Klir.TechChallenge.Web.Domain.Models.DTO;
using Klir.TechChallenge.Web.Mvc.Features.Command.User;
using Klir.TechChallenge.Web.Mvc.Features.Helper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Controllers
{
    public class AccountController : BaseController
    {
        private IMediator _mediator;
        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateModel]
        public async Task<IActionResult> Login(LoginPayload loginDTO, string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData["alert_data"] = Alert.ShowAlert(AlertStatus.Error, "Please logout before attempting to login again");
                return Redirect("/");
            }
            if (!ModelState.IsValid) return View(loginDTO);
            var result = await _mediator.Send(new LoginCommand(email: loginDTO.Email, password: loginDTO.Password));
            if (result.Status) return RedirectToLocal(returnUrl);
            ModelState.AddModelError("", "invalid credentials");
            return View(loginDTO);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

    }
}
