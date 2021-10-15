using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace JayrideCodingChallenge.WebSite.Services
{
    public class CommonService
    {
        //Get the response from the Uri
        public static async Task<string> GetByUri(Uri u)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        } 
    }
}
