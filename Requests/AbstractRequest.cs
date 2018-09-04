namespace Paygenius.Requests
{
      public class AbstractRequest
    {
        protected string endpoint { get; set; }
        protected string method { get; set; }

        public AbstractRequest(string endpoint = null, string method = null)
        {
            this.endpoint   = endpoint;
            this.method     = method;   
        }

        public string getEndpoint()
        {
            return this.endpoint;
        }

        public string getMethod()
        {
            return this.method;
        }
    }
}