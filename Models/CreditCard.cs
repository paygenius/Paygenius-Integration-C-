namespace Paygenius.Models
{
    public class CreditCard
    {
        public string number {get; set;}
        public string cardHolder {get; set;}
        public string expiryYear {get; set;}
        public string expiryMonth {get; set;}
        public string cvv {get; set;}
        public string type {get; set;}
        public string uniqueId {get; set;}
    }
}