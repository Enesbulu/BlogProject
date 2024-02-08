namespace BlogProject.Core.CrossCuttingConcerns.Exceptions.Types
{
    public class ValidationException : Exception
    {
        public IEnumerable<ValidationExceptionModel> Errors { get; }
        public ValidationException()
        {
            Errors = Array.Empty<ValidationExceptionModel>();
        }

        public ValidationException(string? message) : base(message)
        {
            Errors = Array.Empty<ValidationExceptionModel>();
        }

        public ValidationException(string? message, Exception? innerException) : base(message, innerException)
        {
            Errors = Array.Empty<ValidationExceptionModel>();
        }

        public ValidationException(IEnumerable<ValidationExceptionModel> errors) : base(BuildErrorMessages(errors))
        {
            Errors = errors;
        }

        private static string BuildErrorMessages(IEnumerable<ValidationExceptionModel> errors)
        {
            IEnumerable<string> validationArr = errors.Select(x => $"{Environment.NewLine} -- {x.Property} : {string.Join(Environment.NewLine, values: x.Messages ?? Array.Empty<string>())}");

            return $"Validation failed : {string.Join(string.Empty, validationArr)}";
        }
    }

    public class ValidationExceptionModel
    {
        public string? Property { get; set; }
        public IEnumerable<string>? Messages { get; set; }

    }
}
