using BlogProject.Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails
{
    public class ValidationProblemDetails : ProblemDetails
    {
        public IEnumerable<ValidationExceptionModel> Errors { get; init; }
        public ValidationProblemDetails(IEnumerable<ValidationExceptionModel> errors)
        {
            Errors = errors;
            Title = "Validation error(s)";
            Detail = "One or more validation errors occurred.";
            Status = StatusCodes.Status400BadRequest;
            Type = "https://httpstatuses.com/400";
        }
    }
}
