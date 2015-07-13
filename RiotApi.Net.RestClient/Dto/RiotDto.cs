using Newtonsoft.Json;

namespace RiotApi.Net.RestClient.Dto
{
    /// <summary>
    /// This is the basic Riot Dto object
    /// </summary>
    public class RiotDto
    {
        /// <summary>
        /// Serializes Dto to Json
        /// </summary>
        /// <returns>Json</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
