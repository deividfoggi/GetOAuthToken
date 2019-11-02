using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace GetOAuthToken
{
    public class CredentialRequest
    {
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }

    public class AuthorizationToken
    {
        public string Token_Type { get; set; }
        public double Expires_In { get; set; }
        public double Not_Before { get; set; }
        public double Expires_On { get; set; }
        public string Resource { get; set; }
        public string Access_Token { get; set; }

    }

    public class Mail
    {
        public string subject { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string APIUrl { get; set; }
    }

    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static public void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        static public AuthorizationToken RunAsync(string TenantId, string ClientId, string ClientSecret)
        {
           
            CredentialRequest credentialRequest = new CredentialRequest
            {
                TenantId = TenantId,
                ClientId = ClientId,
                ClientSecret = ClientSecret
            };

            string uri = "https://login.microsoftonline.com/" + TenantId + "/oauth2/v2.0/token/";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.MaximumAutomaticRedirections = 4;
            webRequest.MaximumResponseHeadersLength = 4;

            var postData = "client_id=" + ClientId;
                postData += "&scope=https://graph.microsoft.com/.default";
                postData += "&client_secret=" + ClientSecret;
                postData += "&grant_type=client_credentials";

            var data = ASCIIEncoding.ASCII.GetBytes(postData);

            webRequest.ContentLength = data.Length;

            Stream sendStream = webRequest.GetRequestStream();
            sendStream.Write(data, 0, data.Length);
            sendStream.Close();

            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            string result = readStream.ReadToEnd();

            AuthorizationToken deserializedResult = JsonConvert.DeserializeObject<AuthorizationToken>(result);

            response.Close();
            readStream.Close();

            return deserializedResult;
        }

        static public Mail RunAsync(string APIUrl)
        {
            string uri = "https://graph.microsoft.com/v1.0/";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.MaximumAutomaticRedirections = 4;
            webRequest.MaximumResponseHeadersLength = 4;

            var postData = "APIUrl";

            var data = ASCIIEncoding.ASCII.GetBytes(postData);

            webRequest.ContentLength = data.Length;

            Stream sendStream = webRequest.GetRequestStream();
            sendStream.Write(data, 0, data.Length);
            sendStream.Close();

            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            string result = readStream.ReadToEnd();


            Mail deserializedResult = JsonConvert.DeserializeObject<Mail>(result);

            response.Close();
            readStream.Close();

            return deserializedResult;
        }
    }
}