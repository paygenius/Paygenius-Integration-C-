using Paygenius.Requests;
using System.Text;

namespace Paygenius.Requests
{
    public class ConfirmPaymentRequest: AbstractRequest
    {
        public string reference;
        public string paRes;

        public ConfirmPaymentRequest(string reference, string paRes)
        {
            this.method = "POST";
            this.endpoint = "payment/{0}/confirm";
        }

        new public string getEndpoint()
        {
            return string.Format(this.endpoint, this.reference);
        }
    }
}