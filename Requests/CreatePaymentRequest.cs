using Paygenius.Models;

namespace Paygenius.Requests
{
    public class CreatePaymentRequest:AbstractRequest
    {
        public CreditCard creditCard;
        public Consumer consumer;
        public bool threeDSecure;
        public Transaction transaction;

        public CreatePaymentRequest(CreditCard creditCard,Transaction transaction, bool threeDSecure, Consumer consumer)
        {
            this.endpoint = "payment/create";
            this.method = "POST";

            this.creditCard = creditCard;
            this.consumer = consumer;
            this.transaction = transaction;
            this.threeDSecure = threeDSecure;
        }
    }
}