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

        ILeague League { get; set; }

        ILolStaticData LolStaticData { get; set; }

        ILolStatus LolStatus { get; set; }


    }
}
