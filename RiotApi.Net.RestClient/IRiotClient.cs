using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient
{
    /// <summary>
    /// Full API Reference (REST)
    /// </summary>
    public interface IRiotClient
    {
        /// <summary>
        /// champion-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        IChampion Champion { get; set; }
        /// <summary>
        /// current-game-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
        /// </summary>
        ICurrentGame CurrentGame { get; set; }
        /// <summary>
        /// featured-games-v1.0 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
        /// </summary>
        IFeaturedGames FeaturedGames { get; set; }
        /// <summary>
        /// game-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        IGame Game { get; set; }
        /// <summary>
        /// league-v2.5 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        ILeague League { get; set; }
        /// <summary>
        /// lol-static-data-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR]
        /// </summary>
        ILolStaticData LolStaticData { get; set; }
        /// <summary>
        /// lol-status-v1.0 [BR, EUNE, EUW, LAN, LAS, NA, OCE, PBE, RU, TR]
        /// </summary>
        ILolStatus LolStatus { get; set; }
        /// <summary>
        /// match-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        IMatch Match { get; set; }
        /// <summary>
        /// matchhistory-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        IMatchHistory MatchHistory { get; set; }
        /// <summary>
        /// matchlist-v2.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        IMatchList MatchList { get; set; }
        /// <summary>
        /// stats-v1.3 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        IStats Stats { get; set; }
        /// <summary>
        /// summoner-v1.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        ISummoner Summoner { get; set; }
        /// <summary>
        /// team-v2.4 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, RU, TR]
        /// </summary>
        ITeam Team { get; set; }
    }
}
