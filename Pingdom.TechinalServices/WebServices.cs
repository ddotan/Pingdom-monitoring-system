using Newtonsoft.Json;
using Pingdom.ObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Pingdom.TechinalServices
{
    public class WebServices
    {
        //private readonly string r_UserName;
        //private readonly string r_Password;
        private readonly string r_AuthToken;
        private readonly string r_URL = string.Empty;
        private WebServices(string i_AuthToken, string i_URL)
        {
            r_AuthToken = i_AuthToken;
            r_URL = i_URL;

        }
        public static WebServices Connect(string i_AuthToken, string i_URL)
        {
            WebServices webs = new WebServices(i_AuthToken, i_URL);
            return webs;
        }

        public string HTTPPostRequest(string i_Data)
        {

            byte[] dataStream = Encoding.UTF8.GetBytes(i_Data);

            WebRequest webRequest = WebRequest.Create(r_URL);
            webRequest.Method = "POST";
            string autorization = string.Empty;
            byte[] binaryAuthorization = System.Text.Encoding.UTF8.GetBytes(r_AuthToken);
            autorization = Convert.ToBase64String(binaryAuthorization);
            autorization = "Zoho-authtoken " + autorization;
            webRequest.Headers.Add("AUTHORIZATION", autorization);
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = dataStream.Length;
            Stream newStream = webRequest.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);
            newStream.Close();
            StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
            string responseData = responseReader.ReadToEnd();
            responseReader.Close();
            webRequest.GetResponse().Close();
            return responseData;
        }

    }
}

