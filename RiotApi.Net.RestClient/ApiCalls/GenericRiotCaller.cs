using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using NLog;
using RiotApi.Net.RestClient.Helpers;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class GenericRiotCaller
    {
        static readonly Logger Logger = LogManager.GetLogger("RiotCaller");

        public static T MakeCallToRiotApi<T>(string baseUrl, string apiCallPath)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var completeUrl = $"{baseUrl}{apiCallPath}";
                Logger.Debug($"RiotApi.Net : {completeUrl}");
                HttpResponseMessage response = client.GetAsync(completeUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    //deserialize json to object
                    try
                    {
                        Logger.Debug($"RiotApi.Net : {completeUrl} - Success");
                        T dto = JsonConvert.DeserializeObject<T>(json);
                        return dto;
                    }
                    catch (JsonSerializationException exception)
                    {
                        Logger.Debug($"RiotApi.Net : {completeUrl} - Fail");
                        Logger.Error(exception);
                        throw RiotExceptionRaiser.RaiseException(0);
                    }
                }
                //for error status code
                Logger.Debug($"RiotApi.Net : {completeUrl} - Fail with status code {response.StatusCode}");
                throw RiotExceptionRaiser.RaiseException((int)response.StatusCode);
            }
        }
    }
}
