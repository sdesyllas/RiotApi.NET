using System;
using System.Configuration;
using System.Linq;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class CurrentGameTests
    {
        /// <summary>
        /// IOC (Inversion of Control) container
        /// https://en.wikipedia.org/wiki/Inversion_of_control
        /// </summary>
        private static IContainer Container { get; set; }
        private static ILifetimeScope Scope { get; set; }

        [TestFixtureSetUp]
        public void Init()
        {
            // Create your builder.
            var builder = new ContainerBuilder();
            // Register individual components
            builder.RegisterInstance(new CurrentGame(ConfigurationManager.AppSettings["ApiKey"])).As<ICurrentGame>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetCurrentGameInformationForSummoner()
        {
            var api = Scope.Resolve<ICurrentGame>();
            try
            {
                var dto = api.GetCurrentGameInformationForSummonerId(RiotApiConfig.Platforms.EUN1, 41488614);
                Assert.NotNull(dto);
                Console.WriteLine($"Summoner's current game : {dto.GameId}");
                Console.WriteLine($"Summoner's game mode : {dto.GameMode}");
                Console.WriteLine($"Summoner's game length in seconds : {dto.GameLength}");
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine(
                        $"Summoner is not currently playing any game! msg : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test error", riotException);
                }
            }
        }
    }
}