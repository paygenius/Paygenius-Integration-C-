using Paygenius.Models;

namespace Paygenius.Requests
{
    public class CreateInstantEftRequest:AbstractRequest
    {
        public Transaction transaction;
        public Consumer consumer;
        public Urls urls;
        public CreateInstantEftRequest(Transaction transaction,Consumer consumer, Urls urls)
        {
            this.endpoint = "payment/create/eft";
            this.method = "POST";

            this.transaction = transaction;
            this.consumer = consumer;
            this.urls = urls;
        }
    }
}