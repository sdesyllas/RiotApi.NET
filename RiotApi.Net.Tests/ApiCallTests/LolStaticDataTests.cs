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
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetChampionList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, champData: "all", locale: "el_GR");
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
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetChampionById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 254);
            Assert.NotNull(dto);
            Assert.AreEqual(254, dto.Id);
            Console.WriteLine($"Champion : {dto.Title}");
        }

        [Test]
        public void GetItemList()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetItemList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, itemListData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetItemById()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetItemById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 1300, itemData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Console.WriteLine($"item: {dto.Name}, {dto.Image.Full}");
        }

        [Test]
        public void GetLanguageStrings()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetLanguageStrings(RestClient.Configuration.RiotApiConfig.Regions.EUNE, locale: "el_GR");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetSupportedLanguages()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetSupportedLanguages(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            dto.ToList().ForEach(Console.WriteLine);
        }

        [Test]
        public void GetMapData()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetMapData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetMasteryList()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetMasteryList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, masteryListData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetMasteryById()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetMasteryById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 6121, masteryData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(6121, dto.Id);
            Console.WriteLine($"mastery:{dto.Name}, {dto.Description.FirstOrDefault()}, {dto.Image.Full}");
        }

        [Test]
        public void GetRealmData()
        {
            var eune = GlobalSetup.RiotHttpClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(eune);
            Console.WriteLine(eune);

            var na = GlobalSetup.RiotHttpClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.NA);
            Assert.NotNull(na);
            Console.WriteLine(na);

            var kr = GlobalSetup.RiotHttpClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.KR);
            Assert.NotNull(kr);
            Console.WriteLine(kr);

            var euw = GlobalSetup.RiotHttpClient.LolStaticData.GetRealmData(RestClient.Configuration.RiotApiConfig.Regions.EUW);
            Assert.NotNull(euw);
            Console.WriteLine(euw);
        }

        [Test]
        public void GetRuneList()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetRuneList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, runeListData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Console.WriteLine(dto.Data.FirstOrDefault().Value.Id);
        }

        [Test]
        public void GetRuneById()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetRuneById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 5235, runeData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(5235, dto.Id);
        }

        [Test]
        public void GetSummonerSpellList()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetSummonerSpellList(RestClient.Configuration.RiotApiConfig.Regions.EUNE, spellData:"all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
        }

        [Test]
        public void GetSummonerSpellById()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetSummonerSpellById(RestClient.Configuration.RiotApiConfig.Regions.EUNE, 1, spellData: "all");
            Assert.NotNull(dto);
            Console.WriteLine(dto);
            Assert.AreEqual(1, dto.Id);
        }

        [Test]
        public void GetVersionData()
        {
            var dto = GlobalSetup.RiotHttpClient.LolStaticData.GetVersionData(RestClient.Configuration.RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            dto.ToList().ForEach(Console.WriteLine);
        }
    }
}