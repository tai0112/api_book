using FluentValidation.Results;

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
