using System;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using RiotApi.Net.RestClient.ApiCalls;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class LolStaticDataTests
    {
        [Test]
        public void GetChampionList()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetChampionList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, champData: "all", locale: "el_GR");
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
            var dto = GlobalSetup.RiotClient.LolStaticData.GetChampionById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 254);
            Assert.NotNull(dto);
            Assert.AreEqual(254, dto.Id);
            Console.WriteLine($"Champion : {dto.Title}");
        }

        [Test]
        public void GetItemList()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetItemList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, itemListData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetItemById()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetItemById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 1300, itemData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Console.WriteLine($"item: {dto.Name}, {dto.Image.Full}");
        }

        [Test]
        public void GetLanguageStrings()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetLanguageStrings(RestClient.Configuration.RiotApiConfig.Regions.EUNE, locale: "el_GR");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetSupportedLanguages()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetSupportedLanguages(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            dto.ToList().ForEach(Console.WriteLine);
        }

        [Test]
        public void GetMapData()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetMapData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetMasteryList()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetMasteryList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, masteryListData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetMasteryById()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetMasteryById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 4214, masteryData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(4214, dto.Id);
            Console.WriteLine($"mastery:{dto.Name}, {dto.Description.FirstOrDefault()}, {dto.Image.Full}");
        }

        [Test]
        public void GetRealmData()
        {
            var eune = GlobalSetup.RiotClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(eune);
            Console.WriteLine(eune);

            var na = GlobalSetup.RiotClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.NA);
            Assert.NotNull(na);
            Console.WriteLine(na);

            var kr = GlobalSetup.RiotClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.KR);
            Assert.NotNull(kr);
            Console.WriteLine(kr);

            var euw = GlobalSetup.RiotClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.EUW);
            Assert.NotNull(euw);
            Console.WriteLine(euw);
        }

        [Test]
        public void GetRuneList()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetRuneList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, runeListData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Console.WriteLine(dto.Data.FirstOrDefault().Value.Id);
        }

        [Test]
        public void GetRuneById()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetRuneById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 5235, runeData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(5235, dto.Id);
        }

        [Test]
        public void GetSummonerSpellList()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetSummonerSpellList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, spellData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetSummonerSpellById()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetSummonerSpellById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 1, spellData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(1, dto.Id);
        }

        [Test]
        public void GetVersionData()
        {
            var dto = GlobalSetup.RiotClient.LolStaticData.GetVersionData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            dto.ToList().ForEach(Console.WriteLine);
        }
    }
}