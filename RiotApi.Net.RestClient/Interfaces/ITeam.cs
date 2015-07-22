using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.Team;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// team-v2.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public interface ITeam
    {
        /// <summary>
        /// Get teams mapped by summoner ID for a given list of summoner IDs.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs. Maximum allowed at once is 10.</param>
        /// <returns>Return Value: Map[string, List[TeamDto]] TeamDto - This object contains team information.</returns>
        Dictionary<string, IEnumerable<TeamDto>> GetTeamsBySummonerId(RiotApiConfig.Regions region,
            params string[] summonerIds);

        /// <summary>
        /// Get teams mapped by team ID for a given list of team IDs.
        /// </summary>
        /// <param name="region">The region of the summoner.</param>
        /// <param name="teamIds">Comma-separated list of team IDs. Maximum allowed at once is 10.</param>
        /// <returns>Return Value: Map[string, TeamDto] TeamDto - This object contains team information.</returns>
        Dictionary<string, TeamDto> GetTeamsByTeamId(RiotApiConfig.Regions region, params string[] teamIds);
    }
}
