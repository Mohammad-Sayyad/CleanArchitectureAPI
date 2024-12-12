using Microsoft.AspNetCore.Mvc;

namespace SOLID.CleanArchitecture_.NET.API.Model
{
    public class CustomProblemDetails : ProblemDetails
    {
        public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    }
}
