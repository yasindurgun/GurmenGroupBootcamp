using Microsoft.AspNetCore.Diagnostics;
using Week3.API_Odev.DTOs;

namespace Week3.API_Odev.Middlewares
{
    public static class GlobalExceptionHandlerMiddleware
    {
        public static void UseGlobalExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(options =>
            {
                options.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();

                    var exception = exceptionFeature.Error;

                    context.Response.StatusCode = 500;
                    await context.Response.WriteAsJsonAsync<ResponseDto<NoContent>>(ResponseDto<NoContent>.Fail(exception.Message));
                });
            });
        }
    }
}
