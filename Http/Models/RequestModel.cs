using System.Collections.Generic;

namespace CustomsCalc.Http.Models
{
    public class RequestModel
    {
        public string TypeMethod { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Querystring { get; set; }
        public string ContentType { get; set; }
        public string JsonString { get; set; }
        public List<Header> Headers { get; set; }

        public RequestModel()
        {

        }

        public RequestModel(string TypeMethod, string Host,
            string Port, string Querystring, string ContentType,
            string JsonString, List<Header> Headers)
        {
            this.TypeMethod = TypeMethod;
            this.Host = Host;
            this.Port = Port;
            this.Querystring = Querystring;
            this.ContentType = ContentType;
            this.JsonString = JsonString;
            this.Headers = Headers;
        }
        public RequestModel(string TypeMethod, string Host,
        string Port, string Querystring, string ContentType,
        List<Header> Headers)
        {
            this.TypeMethod = TypeMethod;
            this.Host = Host;
            this.Port = Port;
            this.Querystring = Querystring;
            this.ContentType = ContentType;
            this.Headers = Headers;
        }

        public RequestModel(string TypeMethod, string Host,
          string Port, string Querystring, string ContentType)
        {
            this.TypeMethod = TypeMethod;
            this.Host = Host;
            this.Port = Port;
            this.Querystring = Querystring;
            this.ContentType = ContentType;
        }

        public RequestModel(string TypeMethod, string Host,
         string Port, string Querystring, string ContentType, string json)
        {
            this.TypeMethod = TypeMethod;
            this.Host = Host;
            this.Port = Port;
            this.Querystring = Querystring;
            this.ContentType = ContentType;
            this.JsonString = json;
        }
    }
}
