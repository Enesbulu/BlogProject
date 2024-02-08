using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Core.CrossCuttingConcerns.Exceptions.Extensions
{
    public static class ProblemDetailsExtensions
    {
        public static string AsJson<TProblemDetails>(this TProblemDetails details) where TProblemDetails :
            ProblemDetails
        {
            return JsonSerializer.Serialize(details);
        }
    }
}
