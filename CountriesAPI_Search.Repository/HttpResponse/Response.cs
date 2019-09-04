using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAPI_Search.Domain.HttpResponse
{
    public static class Response
    {
        public static async Task<HttpResponseMessage> GetResponse(Uri inputUri)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(inputUri);
                    response.EnsureSuccessStatusCode();
                    return response;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }
            }
        }
    }
}
