using System;

namespace AsaasClient.Core.Extension;

internal static class DateTimeExtensions
{
    public static string ToApiRequest(this DateTime dateTime)
    {
        return dateTime.ToString("yyyy-MM-dd");
    }
}