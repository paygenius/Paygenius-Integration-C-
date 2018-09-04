using Paygenius.Requests;

namespace Paygenius.Requests
{
    public class PaymentLookupRequest: AbstractRequest
    {
        public string reference;
        public PaymentLookupRequest (string reference)
        {
            this.reference = reference;
            this.endpoint = "redirect/{0}";
            this.method = "POST";
        }

        new public string getEndpoint()
        {
            return string.Format(this.endpoint, this.reference);
        }
    } 
}