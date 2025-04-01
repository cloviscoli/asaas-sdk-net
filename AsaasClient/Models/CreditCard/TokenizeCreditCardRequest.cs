using AsaasClient.Models.Common;
using Newtonsoft.Json;

namespace AsaasClient.Models.CreditCard;

public class TokenizeCreditCardRequest
{
    [JsonProperty(PropertyName = "customer")]
    public string Customer { get; set; }

    [JsonProperty(PropertyName = "creditCard")]
    public CreditCardRequest CreditCard { get; set; }

    [JsonProperty(PropertyName = "creditCardHolderInfo")]
    public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }

    [JsonProperty(PropertyName = "remoteIp")]
    public string RemoteIp { get; set; }
}