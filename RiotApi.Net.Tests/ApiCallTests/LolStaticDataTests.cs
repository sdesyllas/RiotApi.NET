using System;
using System.Configuration;
using System.Linq;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class LolStaticDataTests
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
            builder.RegisterInstance(new LolStaticData(ConfigurationManager.AppSettings["ApiKey"])).As<ILolStaticData>();
            Container = builder.Build();
            Scope = Container.BeginLifetimeScope();
            Scope.Resolve<ILolStaticData>();
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Scope.Dispose();
        }

        [Test]
        public void GetChampionList()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetChampionList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, champData: "all", locale:"el_GR");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            foreach (var champion in dto.Data.Values)
            {
                Console.WriteLine($"Champion : {champion.Title}");
            }
        }

        [Test]
        public void GetChampionById()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetChampionById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 254);
            Assert.NotNull(dto);
            Assert.AreEqual(254, dto.Id);
            Console.WriteLine($"Champion : {dto.Title}");
        }

        [Test]
        public void GetItemList()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetItemList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, itemListData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetItemById()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetItemById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 1300, itemData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Console.WriteLine($"item: {dto.Name}, {dto.Image.Full}");
        }

        [Test]
        public void GetLanguageStrings()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetLanguageStrings(RestClient.Configuration.RiotApiConfig.Regions.EUNE, locale:"el_GR");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetSupportedLanguages()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetSupportedLanguages(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            dto.ToList().ForEach(Console.WriteLine);
        }
    }
}