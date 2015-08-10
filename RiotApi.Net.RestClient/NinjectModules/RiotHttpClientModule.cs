using Ninject.Modules;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.NinjectModules
{
    /// <summary>
    /// With Ninject, your type bindings are collected into groups called modules. 
    /// Each of these modules represents an independent segment of your application. 
    /// They can be organized as you see fit in order to segregate your system into subsystems in a way that makes 
    /// your overall architecture easy to grok. Modules just need to implement the INinjectModule interface, 
    /// but most should extend the NinjectModule class for simplicity.
    /// </summary>
    public class RiotHttpClientModule : NinjectModule
    {
        private static string _apiKey;

        public RiotHttpClientModule(string apiKey)
        {
            _apiKey = apiKey;
        }

        public override void Load()
        {
            //let ninject glue things together
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
        }
    }
}
