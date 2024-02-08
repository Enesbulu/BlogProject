using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class AuthorizationProblemDetails: ProblemDetails
    {
        public AuthorizationProblemDetails(string detail)
        {
            Title = "Authorization Error";
            Detail = detail;
            Status = StatusCodes.Status401Unauthorized;
            Type = "https://httpstatuses.com/401";
        }
    }
}
