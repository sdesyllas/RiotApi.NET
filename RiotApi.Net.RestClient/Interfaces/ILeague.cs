using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// league-v2.5 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR] 
    /// </summary>
    public interface ILeague
    {
        /// <summary>
        /// Get leagues mapped by summoner ID for a given list of summoner IDs.
        /// Implementation Notes :
        /// Returns all leagues for specified summoners and summoners' teams. Entries for each requested participant 
        /// (i.e., each summoner and related teams) will be included in the returned leagues data, 
        /// whether or not the participant is inactive. However, no entries for other inactive summoners or teams in the leagues will be included.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        Dictionary<string, IEnumerable<LeagueDto>> GetSummonerLeaguesByIds(RiotApiConfig.Regions region, params string[] summonerIds);

        /// <summary>
        /// Get league entries mapped by summoner ID for a given list of summoner IDs.
        /// Implementation Notes :
        /// Returns all league entries for specified summoners and summoners' teams.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="summonerIds">Comma-separated list of summoner IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        Dictionary<string, IEnumerable<LeagueDto>> GetSummonerLeagueEntriesByIds(RiotApiConfig.Regions region, params string[] summonerIds);

        /// <summary>
        /// Get leagues mapped by team ID for a given list of team IDs.
        /// Implementation Notes :
        /// Returns all leagues for specified teams.Entries for each requested team will be included in the returned leagues data, 
        /// whether or not the team is inactive.However, no entries for other inactive teams in the leagues will be included.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="teamIds">Comma-separated list of team IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        Dictionary<string, IEnumerable<LeagueDto>> GetTeamLeaguesbyIds(RiotApiConfig.Regions region, params string[] teamIds);

        /// <summary>
        /// Get league entries mapped by team ID for a given list of team IDs.
        /// Implementation Notes
        /// Returns all league entries for specified teams.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="teamIds">Comma-separated list of team IDs. Maximum allowed at once is 10.</param>
        /// <returns>Map[string, List[LeagueDto]] LeagueDto - This object contains league information.</returns>
        Dictionary<string, IEnumerable<LeagueDto>> GetTeamLeagueEntriesbyIds(RiotApiConfig.Regions region, params string[] teamIds);

        /// <summary>
        /// Get challenger tier leagues.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="type">Game queue type.</param>
        /// <returns>LeagueDto - This object contains league information.</returns>
        LeagueDto GetChallengerTierLeagues(RiotApiConfig.Regions region, Helpers.Enums.GameQueueType type);

        /// <summary>
        /// Get master tier leagues.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="type">Game queue type.</param>
        /// <returns>LeagueDto - This object contains league information.</returns>
        LeagueDto GetMasterTierLeagues(RiotApiConfig.Regions region, Helpers.Enums.GameQueueType type);
    }
}
