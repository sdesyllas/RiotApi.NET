using System;
using System.Configuration;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class StatsTests
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
            builder.RegisterInstance(new Stats(ConfigurationManager.AppSettings["ApiKey"])).As<IStats>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [TestCase(41488614)]
        [TestCase(22293716)]
        public void GetRankedStatsBySummonerId(long summonerId)
        {
            var api = Scope.Resolve<IStats>();
            try
            {
                var dto = api.GetRankedStatsBySummonerId(RiotApiConfig.Regions.EUNE, summonerId);
                Assert.NotNull(dto);
                Assert.AreEqual(summonerId, dto.SummonerId);
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine($"stats not found : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test exception", riotException);
                }
            }
        }

        [TestCase(41488614)]
        [TestCase(22293716)]
        public void GetPlayerStatsBySummonerId(long summonerId)
        {
            var api = Scope.Resolve<IStats>();
            try
            {
                var dto = api.GetPlayerStatsBySummonerId(RiotApiConfig.Regions.EUNE, summonerId);
                Assert.NotNull(dto);
                Assert.AreEqual(summonerId, dto.SummonerId);
                Console.WriteLine(dto.ToString());
            }
            catch (RiotExceptionRaiser.RiotApiException riotException)
            {
                if (riotException.RiotErrorCode == RiotExceptionRaiser.RiotErrorCode.DATA_NOT_FOUND)
                {
                    Console.WriteLine($"stats not found : {riotException.Message}. Error:{riotException.RiotErrorCode}");
                }
                else
                {
                    throw new Exception("test exception", riotException);
                }
            }
        }
    }
}