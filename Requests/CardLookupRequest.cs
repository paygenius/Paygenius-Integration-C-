using Paygenius.Requests;

namespace Paygenius.Requests
{
    public class CardLookupRequest: AbstractRequest
    {
        public string cardNumber;
        public CardLookupRequest (string cardNumber)
        {
            this.cardNumber = cardNumber;
            this.endpoint = "card/lookup";
            this.method = "POST";
        }
    } 
}