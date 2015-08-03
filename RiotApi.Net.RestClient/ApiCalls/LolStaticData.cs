using System;
using System.Collections.Generic;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using RiotApi.Net.RestClient.Dto.LolStaticData.Item;
using RiotApi.Net.RestClient.Dto.LolStaticData.LanguageStrings;
using RiotApi.Net.RestClient.Dto.LolStaticData.Map;
using RiotApi.Net.RestClient.Dto.LolStaticData.Mastery;
using RiotApi.Net.RestClient.Dto.LolStaticData.Realm;
using RiotApi.Net.RestClient.Dto.LolStaticData.Rune;
using RiotApi.Net.RestClient.Dto.LolStaticData.SummonerSpell;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient.ApiCalls
{
    public class LolStaticData: GenericRiotCaller, ILolStaticData
    {
        public LolStaticData(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        public string ApiKey { get; set; }

        public ChampionListDto GetChampionList(RiotApiConfig.Regions region, bool? dataById = null, string locale = null, string version = null,
            string champData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/champion?api_key={this.ApiKey}";
            //add additional parameters
            if (dataById.HasValue)
            {
                apiCallPath += $"&dataById={dataById}";
            }
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={locale}";
            }
            if (!string.IsNullOrEmpty(champData))
            {
                apiCallPath += $"&champData={champData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<ChampionListDto>(baseUrl, apiCallPath);
            return dto;
        }

        public ChampionDto GetChampionById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string champData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/champion/254?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/eune/v1.2/champion/{id}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={locale}";
            }
            if (!string.IsNullOrEmpty(champData))
            {
                apiCallPath += $"&champData={champData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<ChampionDto>(baseUrl, apiCallPath);
            return dto;
        }

        public ItemListDto GetItemList(RiotApiConfig.Regions region, string locale = null, string version = null, string itemListData = null)
        {
            throw new NotImplementedException();
        }

        public ItemDto GetItemById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string itemData = null)
        {
            throw new NotImplementedException();
        }

        public LanguageStringsDto GetLanguageStrings(RiotApiConfig.Regions region, string locale = null, string version = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSupportedLanguages(RiotApiConfig.Regions region)
        {
            throw new NotImplementedException();
        }

        public MapDataDto GetMapData(RiotApiConfig.Regions region, string locale = null, string version = null)
        {
            throw new NotImplementedException();
        }

        public MasteryListDto GetMasteryList(RiotApiConfig.Regions region, string locale = null, string version = null, string masteryListData = null)
        {
            throw new NotImplementedException();
        }

        public MasteryDto GetMasteryById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string masteryData = null)
        {
            throw new NotImplementedException();
        }

        public RealmDto GetRealData(RiotApiConfig.Regions region)
        {
            throw new NotImplementedException();
        }

        public RuneListDto GetRuneList(RiotApiConfig.Regions region, string locale = null, string version = null, string runeListData = null)
        {
            throw new NotImplementedException();
        }

        public RuneDto GetRuneById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string runeData = null)
        {
            throw new NotImplementedException();
        }

        public SummonerSpellListDto GetSummonerSpellList(RiotApiConfig.Regions region, string locale = null, string version = null,
            bool? dataById = null, string spellData = null)
        {
            throw new NotImplementedException();
        }

        public SummonerSpellDto GetSummernerSpellById(RiotApiConfig.Regions region, int id, string locale = null, string version = null,
            string spellData = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetVersionData(RiotApiConfig.Regions region)
        {
            throw new NotImplementedException();
        }
    }
}
