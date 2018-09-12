using System;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Paygenius.Requests;

namespace Paygenius
{
    public class PaygeniusMainClient
    {
        private string token;
        private string secret;
        private string mainEndpoint;

        public PaygeniusMainClient(string  mainEndpoint, string secret, string token)
        {
            this.mainEndpoint = mainEndpoint;
            this.token = token;
            this.secret = secret;
        }
        public string validate(Validate request)
        {
            return this.send(request);
        }
        public string createPayment(CreatePaymentRequest request)
        {
            return this.send(request);
        }
        public string createPaymentPage(PaymentPageRequest request)
        {
            return this.send(request);
        }
        public string executePayment(ExecutePaymentRequest request)
        {
            return this.send(request);
        }
         public string lookupTransaction(PaymentLookupRequest request)
        {
            return this.send(request);
        }
         public string lookupCard(CardLookupRequest request)
        {
            return this.send(request);
        }
         public string storeCard(StoreCardRequest request)
        {
            return this.send(request);
        }
        public string createEftPayment(CreateInstantEftRequest request)
        {
            return this.send(request);
        }
         public string confirmPayment(ConfirmPaymentRequest request)
        {
            return this.send(request);
        } 

        public string send(AbstractRequest request)
        {
            string data = JsonConvert.SerializeObject(request);
            string fullEndpoint = this.mainEndpoint+request.getEndpoint();
            var nullJsonCheck = data.ToString().Replace("{", "").Replace("}","").Trim();
            var signiture = this.sign(fullEndpoint, String.IsNullOrEmpty(nullJsonCheck) ? null:data);            

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(fullEndpoint);
            httpWebRequest.Accept = "application/json";
            httpWebRequest.Headers["X-Token"] = token;
            httpWebRequest.Headers["X-Signature"] = signiture;

             if (!String.IsNullOrEmpty(nullJsonCheck))
            {
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            else
            {
                httpWebRequest.Method = "GET";
            } 
            
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

        public string sign(string endpoint, string data=null)
        {
                string toSign = endpoint;
                if (data != null)
                {
                    toSign += "\n" + data;
                }

                HMACSHA256 hmac = new HMACSHA256(System.Text.Encoding.Default.GetBytes(this.secret));

                byte[] hash = hmac.ComputeHash(System.Text.Encoding.Default.GetBytes(toSign.Trim()));

                return ByteToString(hash);
        }

        public string ByteToString(byte[] buff)
       {
           string sbinary = "";

           for (int i = 0; i < buff.Length; i++)
           {
               sbinary += buff[i].ToString("X2"); // hex format
           }
           return sbinary.ToLower();
       } 
    }
}