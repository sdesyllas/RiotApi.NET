using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Match;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// match-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public interface IMatch
    {
        /// <summary>
        /// Retrieve match by match ID.
        /// Implementation Notes
        /// Not all matches have timeline data.If timeline data is requested, but doesn't exist, then the response won't include it.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="matchId">The ID of the match.</param>
        /// <param name="includeTimeline">Flag indicating whether or not to include match timeline data</param>
        /// <returns></returns>
        MatchDetail GetMatchById(RiotApiConfig.Regions region, long matchId, bool? includeTimeline = null);
    }
}
