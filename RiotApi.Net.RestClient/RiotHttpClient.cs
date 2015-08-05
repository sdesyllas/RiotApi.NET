using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient
{
    public class RiotHttpClient : IRiotClient
    {
        private static string _apiKey;

        public RiotHttpClient(string apiKey)
        {
            _apiKey = apiKey;
            Champion = new Champion(_apiKey);
            CurrentGame = new CurrentGame(_apiKey);
            FeaturedGames = new FeaturedGames(_apiKey);
            Game = new Game(_apiKey);
            League = new League(_apiKey);
            LolStaticData = new LolStaticData(_apiKey);
            LolStatus = new LolStatus();
            Match = new Match(_apiKey);
            MatchHistory = new MatchHistory(_apiKey);
            MatchList = new MatchList(_apiKey);
            Stats = new Stats(_apiKey);
            Summoner = new Summoner(_apiKey);
            Team = new Team(_apiKey);
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
