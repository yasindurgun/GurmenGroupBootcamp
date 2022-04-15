using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override Task OnExceptionAsync(ExceptionContext context)
        {
            context.ExceptionHandled = true;

            context.Result = new ObjectResult(ResponseDto<NoContent>.Fail($"{context.Exception.Message}", 500)) { StatusCode = 500 };

            return Task.CompletedTask;

        }
    }
}
