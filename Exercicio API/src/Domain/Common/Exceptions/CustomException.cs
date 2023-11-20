using System.Net;

namespace Domain.Common.Exceptions
{
    public class CustomException : Exception
    {
        public List<string> ErrorMessages { get; }
        public HttpStatusCode StatusCode { get; }

        public CustomException(string message, HttpStatusCode statusCode, List<string> errors = default)
        {
            ErrorMessages = errors;
            StatusCode = statusCode;
        }
    }
}
