using BlogProject.Core.CrossCuttingConcerns.Exceptions.Handlers;
using Microsoft.AspNetCore.Http;

namespace BlogProject.Core.CrossCuttingConcerns.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly HttpExceptionHandler _httpExceptionHandler = new();
        public ExceptionMiddleware(RequestDelegate next, IHttpContextAccessor contextAccessor)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandlerExceptionAsync( context.Response, exception);
            }
        }

        private Task HandlerExceptionAsync(HttpResponse httpResponse, Exception exception)
        {
            httpResponse.ContentType = "application/json";
            _httpExceptionHandler.Response = httpResponse;
            return _httpExceptionHandler.HandleExceptionAsync(exception);
        }

    }
}
