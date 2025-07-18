using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using AsaasClient.Core.Extension;

namespace AsaasClient.Core.Response.Base;

public abstract class BaseResponse
{
    public HttpStatusCode StatusCode { get; }

    public List<Error> Errors { get; private set; } = [];

    public string AsaasResponse { get; }

    protected BaseResponse(HttpStatusCode httpStatusCode, string content)
    {
        StatusCode = httpStatusCode;
        AsaasResponse = content;
        BuildErrors();
    }

    private void BuildErrors()
    {
        if (WasSucessfull() || string.IsNullOrEmpty(AsaasResponse))
            return;

        try
        {
            var jObject = JObject.Parse(AsaasResponse);

            if (jObject.ContainsKey("errors"))
                Errors = JsonConvert.DeserializeObject<List<Error>>(jObject.GetValue("errors").ToString());
        }
        catch
        {
            Errors =
            [
                new()
                {
                    Code = "UnknownError",
                    Description = AsaasResponse
                }
            ];
        }
    }

    public bool WasSucessfull() => StatusCode.IsSuccessStatusCode();
}
