using Paygenius.Requests;

namespace Paygenius.Requests
{
    public class Validate:AbstractRequest
    {
        public Validate()
        {
            this.endpoint = "/util/validate";
            this.method = "GET";
        }
    }
}