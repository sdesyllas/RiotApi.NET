using Ninject;
using RiotApi.Net.RestClient.NinjectModules;

namespace RiotApi.Net.RestClient
{
    /// <summary>
    /// Riot Api Client
    /// </summary>
    public class RiotApiLoader
    {
        /// <summary>
        /// Create an HttpClient injecting Riot Http Client Module 
        /// </summary>
        /// <param name="apiKey">Riot Api key</param>
        /// <returns>RiotClient initialized with http modules</returns>
        public static RiotClient CreateHttpClient(string apiKey)
        {
            IKernel kernel = new StandardKernel(new RiotHttpClientModule(apiKey));
            return kernel.Get<RiotClient>();
        }
    }
}
