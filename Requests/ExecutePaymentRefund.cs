using Paygenius.Models;

namespace Paygenius.Requests
{
    public class ExecutePaymentRefund:AbstractRequest
    {
        protected string reference;

        public ExecutePaymentRefund(string reference, double amount)
        {
            this.endpoint = string.Format("payment/{0}/refund", this.reference);
            this.method = "POST";
        }

        new public string getEndpoint()
        {
            return string.Format(this.endpoint, this.reference);
        }
    }
}