using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRDemo.Web.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exceptionType = context.Exception.GetType();
            var response = context.HttpContext.Response;

            if (exceptionType == typeof(ValidationException))
            {
                response.StatusCode = 400;
                response.ContentType = "application/json";
                context.Result = new ObjectResult(context.Exception.Message);
                return;
            }

            context.Result = new StatusCodeResult(500);
            
        }
    }
}
