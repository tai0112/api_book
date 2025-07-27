using System.Web.Mvc;
using FluentValidation.Results;
using HiNetProjectApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HiNetProjectApi.Helpers
{
    public static class ValidationHelper
    {
        public static string FormatErrors(IEnumerable<ValidationFailure> failures)
        {
            return string.Join("; ", failures.Select(e => $"{e.PropertyName}: {e.ErrorMessage}"));
        }
    }
}
