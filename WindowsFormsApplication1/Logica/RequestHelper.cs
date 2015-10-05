using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MKMCrawler.Logica;

namespace MKMCrawler
{
    class RequestHelper
    {
        /// <summary>
        /// Clase que gestiona las llamadas al webservice de MKM
        /// </summary>
        /// <param name="url">URL del webservice que se desea invocar</param>
        public void makeRequest(String url)
        {
            String method = "GET";

            HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
            OAuthHeader header = new OAuthHeader();
            request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
            request.Method = method;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument doc = new XmlDocument();
            doc.Load(response.GetResponseStream());
            // proceed further
        }

        public void updateDatabase()
        {
            String method = "GET";
            String url = "https://www.mkmapi.eu/ws/v1.1/expansion/1/";
            HttpWebRequest request = WebRequest.CreateHttp(url) as HttpWebRequest;
            OAuthHeader header = new OAuthHeader();
            request.Headers.Add(HttpRequestHeader.Authorization, header.getAuthorizationHeader(method, url));
            request.Method = method;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            XmlDocument doc = new XmlDocument();
            doc.Load(response.GetResponseStream());

            // Tratamos la lista de expansiones
            Console.WriteLine(doc.ToString());
        }
    }
}
