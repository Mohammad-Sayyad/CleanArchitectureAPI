
using AngleSharp.Common;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Exceptions
{
    public class BadRequestExceptions : Exception
    {
        public BadRequestExceptions(string message) : base(message)
        {

        }

        public BadRequestExceptions(string message, ValidationResult validationResult) : base(message)
        {
            ValidationErrors = validationResult.ToDictionary();
        }

        public IDictionary<string , string[]> ValidationErrors { get; set; }
    }
}
