using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;
using System.IO;
using System.Diagnostics;
using System.Net.Security;

namespace AppDesktop.Request.Post
{

    

    public class login_post
    {
        // https://172.24.1.178:7292/user/authenticate

        static readonly HttpClient client = new HttpClient();


        public class userLogin
        {
            public string user_name { get; set; }
            public string password { get; set; }


        }


        public static async Task<string> loginPostAsync(string userNameLogin, string userPasswordLogin)
        {
            
            string sURL;
            //sURL = "https://172.24.1.178:7292/user/authenticate"; 172.24.2.67
            sURL = "https://172.24.2.67:7292/user/authenticate";


            KeyValuePair<string, string> password = new KeyValuePair<string, string>("password", userPasswordLogin);

            KeyValuePair<string, string> username = new KeyValuePair<string, string>("user_name", userNameLogin);

            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();

            data.Add(password);
            data.Add(username);

            return await PostFormUrlEncoded(sURL, data);
            /*
            try
            {
                var request = WebRequest.Create(sURL);

            request.Method = "POST";

            // For serialize user data 
            var userLogin = new userLogin
            {
                user_name = userNameLogin,
                password = userPasswordLogin
            };

            var json = JsonSerializer.Serialize(userLogin);
            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            using var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);

            using var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            using var respStream = response.GetResponseStream();

            using var reader = new StreamReader(respStream);
            string data = reader.ReadToEnd();
            Console.WriteLine(data);

            //record User(string Name, string Occupation);

            
                return "200";
            }
            catch(HttpRequestException e)
            {
                return e.Message.GetType().GetProperty("StatusCode").ToString();
            }
            */
        }




        public static async Task<string> PostFormUrlEncoded(string url, IEnumerable<KeyValuePair<string, string>> postData)
        {
            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                using (var httpClient = new HttpClient(clientHandler))
                    {
                        using (var content = new FormUrlEncodedContent(postData))
                        {
                            content.Headers.Clear();
                            content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                            HttpResponseMessage response = await httpClient.PostAsync(url, content);

                            return await response.Content.ReadAsStringAsync();
                        }
                    }
                
                
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return "";
            }
           
        }

    }
}
