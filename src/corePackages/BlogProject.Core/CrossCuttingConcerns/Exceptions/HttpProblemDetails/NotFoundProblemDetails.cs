using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class NotFoundProblemDetails: ProblemDetails
    {
        public NotFoundProblemDetails(string detail)
        {
            Title = "Not found";
            Detail = detail;
            Status = StatusCodes.Status404NotFound;
            Type = "https://httpstatuses.com/404";


        }
    }
}
