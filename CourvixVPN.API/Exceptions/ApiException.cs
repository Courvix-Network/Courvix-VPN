using System.Net;

namespace CourvixVPN.API.Exceptions;

/// <summary>
/// Represents a problem thrown by the Courvix API
/// </summary>
internal class ApiException : Exception
{
    /// <summary>
    /// The HTTP response code from the API
    /// </summary>
    public HttpStatusCode StatusCode { get; }

    public ApiException(string message, HttpStatusCode statusCode = default) : base(message)
    {
        StatusCode = statusCode;
    }
}