using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using RiotApi.Net.RestClient.Helpers;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class GenericRiotCaller
    {
        public static T MakeCallToRiotApi<T>(string baseUrl, string apiCallPath)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = client.GetAsync(apiCallPath).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    //deserialize json to object
                    try
                    {
                        T dto = JsonConvert.DeserializeObject<T>(json);
                        return dto;
                    }
                    catch (JsonSerializationException exception)
                    {
                        throw RiotExceptionRaiser.RaiseException(0);
                    }
                }
                //for error status code
                throw RiotExceptionRaiser.RaiseException((int)response.StatusCode);
            }
        }
    }
}
