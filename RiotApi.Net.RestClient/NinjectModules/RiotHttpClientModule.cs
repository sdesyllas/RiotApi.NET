using Ninject.Modules;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.NinjectModules
{
    public class RiotHttpClientModule : NinjectModule
    {
        private static string _apiKey;

        public RiotHttpClientModule(string apiKey)
        {
            _apiKey = apiKey;
        }

        public override void Load()
        {
            Bind<IChampion>().To<Champion>().WithConstructorArgument(_apiKey);
            Bind<ICurrentGame>().To<CurrentGame>().WithConstructorArgument(_apiKey);
            Bind<IFeaturedGames>().To<FeaturedGames>().WithConstructorArgument(_apiKey);
            Bind<IGame>().To<Game>().WithConstructorArgument(_apiKey);
            Bind<ILeague>().To<League>().WithConstructorArgument(_apiKey);
            Bind<ILolStaticData>().To<LolStaticData>().WithConstructorArgument(_apiKey);
            Bind<ILolStatus>().To<LolStatus>().WithConstructorArgument(_apiKey);
            Bind<IMatch>().To<Match>().WithConstructorArgument(_apiKey);
            Bind<IMatchHistory>().To<MatchHistory>().WithConstructorArgument(_apiKey);
            Bind<IMatchList>().To<MatchList>().WithConstructorArgument(_apiKey);
            Bind<IStats>().To<Stats>().WithConstructorArgument(_apiKey);
            Bind<ISummoner>().To<Summoner>().WithConstructorArgument(_apiKey);
            Bind<ITeam>().To<Team>().WithConstructorArgument(_apiKey);
            Bind<RiotHttpClient>().ToSelf().InSingletonScope().WithConstructorArgument(_apiKey);
        }
    }
}
