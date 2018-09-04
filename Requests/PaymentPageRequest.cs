using Paygenius.Models;

namespace Paygenius.Requests
{
    public class PaymentPageRequest:AbstractRequest
    {
        public CreditCard creditCard;
        public Consumer consumer;
        public Transaction transaction;

        public PaymentPageRequest(CreditCard creditCard, Consumer consumer,Transaction transaction)
        {
            this.endpoint = "redirect/create";
            this.method = "POST";

            this.transaction = transaction;
            this.consumer = consumer;
            this.creditCard = creditCard;
        }
    }
}