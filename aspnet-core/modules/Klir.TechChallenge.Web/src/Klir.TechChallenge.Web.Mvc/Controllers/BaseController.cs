using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Klir.TechChallenge.Web.Mvc.Controllers
{
    public class BaseController : Controller
    {
        public class ValidationError
        {
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string Field { get; }

            public string Message { get; }

            public ValidationError(string field, string message)
            {
                Field = field != string.Empty ? field : null;
                Message = message;
            }
        }

        public class ValidationResultModel
        {
            public string Message { get; }

            public List<ValidationError> Errors { get; }

            public ValidationResultModel(ModelStateDictionary modelState)
            {
                Message = "Validation Failed";
                Errors = modelState.Keys
                        .SelectMany(key => modelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)))
                        .ToList();
            }
        }
        public class ValidationFailedResult : ObjectResult
        {
            public ValidationFailedResult(ModelStateDictionary modelState)
                : base(new ValidationResultModel(modelState))
            {
                StatusCode = StatusCodes.Status400BadRequest;
            }
        }
        public class ValidateModelAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext context)
            {
                if (!context.ModelState.IsValid)
                {
                    context.Result = new ValidationFailedResult(context.ModelState);
                }
            }
        }
    }
}
