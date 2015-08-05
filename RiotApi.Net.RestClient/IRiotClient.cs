using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient
{
    /// <summary>
    /// Full API Reference (REST)
    /// </summary>
    public interface IRiotClient
    {
        IChampion Champion { get; set; }

        ICurrentGame CurrentGame { get; set; }

        IFeaturedGames FeaturedGames { get; set; }

        IGame Game { get; set; }

        ILeague League { get; set; }

        ILolStaticData LolStaticData { get; set; }

        ILolStatus LolStatus { get; set; }

        IMatch Match { get; set; }

        IMatchHistory MatchHistory { get; set; }

        IMatchList MatchList { get; set; }

        IStats Stats { get; set; }

        ISummoner Summoner { get; set; }

        ITeam Team { get; set; }
    }
}
