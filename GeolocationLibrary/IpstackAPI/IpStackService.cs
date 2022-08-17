using GeolocationLibrary;
using GeolocationLibrary.Models;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace GeolocationApi.IpstackApi

{
    public class IpStackService : IIpStackService
    {
        // private readonly HttpClient _httpClient; // "www.ipstack.pl"
        public IpStackService()
        {
        }

        public async Task<GeolocationModel> GetDatafromApiAsync(string ip, CancellationToken ct)
        {
            // var request = new HttpRequestMessage(HttpMethod.Get, "http://api.ipstack.com/"+ip+"?access_key=c809c8b66ad57291fd43abfd99654fd3");
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, IpStackUrlBuilder.BuildUrl("http://api.ipstack.com", ip, "c809c8b66ad57291fd43abfd99654fd3"));
                HttpResponseMessage response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<GeolocationModel>();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
