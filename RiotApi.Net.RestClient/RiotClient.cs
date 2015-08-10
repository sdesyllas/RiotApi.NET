using System.Runtime.CompilerServices;
using Ninject;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient
{
    public class RiotClient : IRiotClient
    {
        public RiotClient(IChampion champion, ICurrentGame currentGame, IFeaturedGames featuredGames, IGame game, ILeague league, ILolStaticData lolStaticData,
            ILolStatus lolStatus, IMatch match, IMatchHistory matchHistory, IMatchList matchList, IStats stats, ISummoner summoner, ITeam team)
        {
            //we need to let Ninject know which concrete type to use to satisfy the interface.
            this.Champion = champion;
            this.CurrentGame = currentGame;
            this.FeaturedGames = featuredGames;
            this.Game = game;
            this.League = league;
            this.LolStaticData = lolStaticData;
            this.LolStatus = lolStatus;
            this.Match = match;
            this.MatchHistory = matchHistory;
            this.MatchList = matchList;
            this.Stats = stats;
            this.Summoner = summoner;
            this.Team = team;
        }

        public IChampion Champion { get; set; }
        public ICurrentGame CurrentGame { get; set; }
        public IFeaturedGames FeaturedGames { get; set; }
        public IGame Game { get; set; }
        public ILeague League { get; set; }
        public ILolStaticData LolStaticData { get; set; }
        public ILolStatus LolStatus { get; set; }
        public IMatch Match { get; set; }
        public IMatchHistory MatchHistory { get; set; }
        public IMatchList MatchList { get; set; }
        public IStats Stats { get; set; }
        public ISummoner Summoner { get; set; }
        public ITeam Team { get; set; }
    }
}
