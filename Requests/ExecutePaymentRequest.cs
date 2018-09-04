using Paygenius.Models;

namespace Paygenius.Requests
{
    public class ExecutePaymentRequest:AbstractRequest
    {
        public string reference;

        public ExecutePaymentRequest(string reference)
        {
            this.endpoint = "payment/{0}/execute";
            this.method = "GET";
        }

        new public string getEndpoint()
        {
            return string.Format(this.endpoint, this.reference);
        }
    }
}