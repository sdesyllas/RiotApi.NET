using System;
using System.Configuration;
using System.Linq;
using Autofac;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
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
            var dto = api.GetChampionList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, champData: "all", locale: "el_GR");
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
            var dto = api.GetItemList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, itemListData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetItemById()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetItemById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 1300, itemData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Console.WriteLine($"item: {dto.Name}, {dto.Image.Full}");
        }

        [Test]
        public void GetLanguageStrings()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetLanguageStrings(RestClient.Configuration.RiotApiConfig.Regions.EUNE, locale: "el_GR");
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

        [Test]
        public void GetMapData()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetMapData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetMasteryList()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetMasteryList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, masteryListData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetMasteryById()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetMasteryById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 4214, masteryData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(4214, dto.Id);
            Console.WriteLine($"mastery:{dto.Name}, {dto.Description.FirstOrDefault()}, {dto.Image.Full}");
        }

        [Test]
        public void GetRealmData()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var eune = api.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(eune);
            Console.WriteLine(eune);

            var na = api.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.NA);
            Assert.NotNull(na);
            Console.WriteLine(na);

            var kr = api.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.KR);
            Assert.NotNull(kr);
            Console.WriteLine(kr);

            var euw = api.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.EUW);
            Assert.NotNull(euw);
            Console.WriteLine(euw);
        }

        [Test]
        public void GetRuneList()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetRuneList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, runeListData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Console.WriteLine(dto.Data.FirstOrDefault().Value.Id);
        }

        [Test]
        public void GetRuneById()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetRuneById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 5235, runeData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(5235, dto.Id);
        }

        [Test]
        public void GetSummonerSpellList()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetSummonerSpellList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, spellData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetSummonerSpellById()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetSummonerSpellById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 1, spellData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(1, dto.Id);
        }

        [Test]
        public void GetVersionData()
        {
            var api = Scope.Resolve<ILolStaticData>();
            var dto = api.GetVersionData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            dto.ToList().ForEach(Console.WriteLine);
        }
    }
}