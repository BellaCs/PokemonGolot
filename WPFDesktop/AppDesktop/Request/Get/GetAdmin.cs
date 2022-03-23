using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop.Request.Get
{
    class GetAdmin
    {
        public static async Task<String> GetAdminList()
        {
            try
            {
                string apiAdmin = "https://172.24.1.178:7292/swagger/index.html";
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(apiAdmin);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

                return null;
            }
        }
    }
}
