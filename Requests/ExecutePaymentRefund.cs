using Paygenius.Models;

namespace Paygenius.Requests
{
    public class ExecutePaymentRefund:AbstractRequest
    {
        public string reference;

        public ExecutePaymentRefund(string reference, double amount)
        {
            this.endpoint = "payment/{0}/refund";
            this.method = "POST";
        }

        new public string getEndpoint()
        {
            return string.Format(this.endpoint, this.reference);
        }
    }
}