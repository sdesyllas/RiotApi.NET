using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;
using System;
using System.Configuration;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class GameTests
    {
        /// <summary>
        /// IOC (Inversion of Control) container
        /// https://en.wikipedia.org/wiki/Inversion_of_control
        /// </summary>
        private static IContainer Container { get; set; }
        private static ILifetimeScope Scope { get; set; }
        public object RiotApiConfig { get; private set; }

        [TestFixtureSetUp]
        public void Init()
        {
            // Create your builder.
            var builder = new ContainerBuilder();
            // Register individual components
            builder.RegisterInstance(new Game(ConfigurationManager.AppSettings["ApiKey"])).As<IGame>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
            Scope.Resolve<IGame>();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetRecentGamesBySummonerId()
        {
            var api = Scope.Resolve<IGame>();
            try
            {
                var dto = api.GetRecentGamesBySummonerId(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 41488614);
                Assert.NotNull(dto);
                Console.WriteLine($"Summoner: {dto.SummonerId}");
                foreach(var game in dto.Games)
                {
                    Assert.IsNotNull(game);
                }
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                Console.WriteLine($"Summoner is not currently playing any game! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
            }
        }

    }
}
