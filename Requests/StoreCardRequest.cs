namespace Paygenius.Requests
{
    public class StoreCardRequest:AbstractRequest
    {
        public  string number;
        public  string cardHolder;
        public  string expiryYear;
        public  string expiryMonth;
        public  string cvv;

        public StoreCardRequest(string number, string cardHolder, string expiryYear, string expiryMonth, string cvv)
        {
            this.endpoint = "card/register";
            this.method = "POST";

            this.number = number;
            this.cardHolder = cardHolder;
            this.expiryYear = expiryYear;
            this.expiryMonth = expiryMonth;
            this.cvv = cvv;
        }
    }
}