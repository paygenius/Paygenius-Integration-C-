using Paygenius.Requests;
using System.Text;

namespace Paygenius.Requests
{
    public class ConfirmPaymentRequest: AbstractRequest
    {
        protected string reference;
        public string paRes;

        public ConfirmPaymentRequest(string reference, string paRes)
        {
            this.method = "POST";
            this.endpoint = string.Format("payment/{0}/confirm", this.reference);
        }
    }
}