using Klir.TechChallenge.SharedLib.Shared.Models;
using Klir.TechChallenge.Web.Mvc.Features.Command.Product;
using Klir.TechChallenge.Web.Mvc.Features.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Mvc.Controllers
{
    public class ProductController : BaseController
    {
        private IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View(_mediator.Send(new ProductsQuery()));
        }
        public ActionResult Create()
        {

            if (TempData["ErrorStatus"] != null)
            {
                ViewBag.ErrorStatus = TempData["ErrorStatus"].ToString();
            }
            return View();
        }

        // POST: MenuItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateModel]
        public async Task<ActionResult> Create(ProductAddPayload payload, IFormFile file)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    if (file != null)
                    {
                        // TODO: Add insert logic here
                        var result = await _mediator.Send(new CreateProductCommand(payload, file));
                        if (result.Status)
                        {
                            TempData["SuccessStatus"] = "product Created Successfully";
                        }
                        else
                        {
                            TempData["ErrorStatus"] = "product Created UnSuccessfully, check the data you are passing";
                            return View();
                        }
                    }
                    else
                    {
                        TempData["Error"] = "File Cannot be empty";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            catch (Exception ex)
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult CreatePromo()
        {

            if (TempData["ErrorStatus"] != null)
            {
                ViewBag.ErrorStatus = TempData["ErrorStatus"].ToString();
            }
            var products = _mediator.Send(new ProductsQuery());
            ViewBag.produst = products;
            return View();
        }

        // POST: MenuItem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateModel]
        public async Task<ActionResult> CreatePromo(ProductPromoPayload payload)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    
                        // TODO: Add insert logic here
                        var result = await _mediator.Send(new CreatePromoCommand(payload));
                        if (result.Status)
                        {
                            TempData["SuccessStatus"] = "promo Created Successfully";
                        }
                        else
                        {
                            TempData["ErrorStatus"] = "promo Created UnSuccessfully, check the data you are passing";
                            return View();
                        }
                }
                else
                {
                    TempData["ErrorStatus"] = "promo Created UnSuccessfully, check the data you are passing";
                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
