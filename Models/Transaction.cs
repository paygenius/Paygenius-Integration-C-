namespace Paygenius.Models
{
    public class Transaction
    {
        public string reference { get; set;}
        public string description { get; set;}
        public string currency { get; set;} = "ZAR";
        public double amount { get; set;}
    }
}