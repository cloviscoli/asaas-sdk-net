using System.Net;

namespace AsaasClient.Core.Extension;

public static class StatusCodeExtensions
{
    public static bool IsSuccessStatusCode(this HttpStatusCode statusCode)
    {
        return (int)statusCode is >= 200 and <= 299;
    }
}