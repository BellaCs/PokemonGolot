using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppDesktop.Request.Post
{
    class login_post
    {
        //https://172.24.1.178:7292/Login/authenticate

        static readonly HttpClient client = new HttpClient();

        public static async Task<string> getPokemons(string gen)
        {
            string sURL;
            sURL = "https://172.24.1.178:7292/Login/authenticate";
            var request = new HttpRequestMessage(HttpMethod.Get, sURL);
            //request.Content ="test" ;

            try
            {
                return "200";
            }
            catch(HttpRequestException e)
            {
                return e.Message.GetType().GetProperty("StatusCode").ToString();
            }

        }

    }
}
