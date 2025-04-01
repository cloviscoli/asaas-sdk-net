using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.CreditCard;
using System.Threading.Tasks;
using AsaasClient.Models.Common;

namespace AsaasClient.Managers
{
    public class CreditCardManager(ApiSettings settings) : BaseManager(settings)
    {
        private const string PaymentsRoute = "/creditCard";

        public async Task<ResponseObject<CreditCard>> TokenizeCreditCard(TokenizeCreditCardRequest requestObj)
        {
            return await PostAsync<CreditCard>($"{PaymentsRoute}/tokenizeCreditCard", requestObj);
        }
    }
}