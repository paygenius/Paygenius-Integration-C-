using Paygenius.Requests;

namespace Paygenius.Requests
{
    public class PaymentLookupRequest: AbstractRequest
    {
        protected string reference;
        public PaymentLookupRequest (string reference)
        {
            this.reference = reference;
            this.endpoint = string.Format("redirect/{0}", this.reference);
            this.method = "GET";
        }
    } 
}