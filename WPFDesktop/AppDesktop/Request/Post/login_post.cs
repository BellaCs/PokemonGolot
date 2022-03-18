using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;
using System.IO;

namespace AppDesktop.Request.Post
{

    

    public class login_post
    {
        // https://172.24.1.178:7292/Login/authenticate

        static readonly HttpClient client = new HttpClient();


        public class userLogin
        {
            public string user_name { get; set; }
            public string password { get; set; }


        }


        public static string loginPost(string userNameLogin, string userPasswordLogin)
        {
            string sURL;
            sURL = "https://172.24.1.178:7292/user/authenticate";
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

        }

    }
}
