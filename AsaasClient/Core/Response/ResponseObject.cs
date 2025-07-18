﻿using AsaasClient.Core.Response.Base;
using Newtonsoft.Json;
using System.Net;

namespace AsaasClient.Core.Response;

public class ResponseObject<T> : BaseResponse
{
    public T Data { get; }

    public ResponseObject(HttpStatusCode httpStatusCode, string content) : base(httpStatusCode, content)
    {
        if (httpStatusCode != HttpStatusCode.OK) return;

        Data = JsonConvert.DeserializeObject<T>(content);
    }
}
