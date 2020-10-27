using CustomsCalc.Http.IEntity;
using CustomsCalc.Http.Models;
using System;
using System.IO;
using System.Net;

namespace CustomsCalc.Http.Repository
{
    public class Request : IRequest
    {

        public string GetRequest(RequestModel repos)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"http://{repos.Host}:{repos.Port}/{repos.Querystring}");
            httpWebRequest.Method = repos.TypeMethod;
            httpWebRequest.ContentType = repos.ContentType;
            if (repos.Headers != null)
            {
                for (int i = 0; i < repos.Headers.Count; i++)
                {
                    httpWebRequest.Headers.Add(" ", $"{repos.Headers[i].NameHeader}" +
                        $"{repos.Headers[i].Body}");
                }
            }

            try
            {
                HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return streamReader.ReadToEnd();
                }
            }

            catch (Exception)
            {
                return null;
            }

        }


        public string PostRequest(RequestModel repos)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"http://{repos.Host}:{repos.Port}/{repos.Querystring}");
            httpWebRequest.Method = repos.TypeMethod;
            httpWebRequest.ContentType = repos.ContentType;
            if (repos.Headers != null)
            {
                for (int i = 0; i < repos.Headers.Count; i++)
                {
                    httpWebRequest.Headers.Add(" ", $"{repos.Headers[i].NameHeader}" +
                        $"{repos.Headers[i].Body}");
                }
            }

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(repos.JsonString);
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

    }
}
