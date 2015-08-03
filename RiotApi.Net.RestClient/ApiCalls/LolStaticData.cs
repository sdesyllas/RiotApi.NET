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
                apiCallPath += $"&version={version}";
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
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/champion/{id}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
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
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/item?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/item?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (!string.IsNullOrEmpty(itemListData))
            {
                apiCallPath += $"&itemListData{itemListData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<ItemListDto>(baseUrl, apiCallPath);
            return dto;
        }

        public ItemDto GetItemById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string itemData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/item/1300?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/item/{id}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (!string.IsNullOrEmpty(itemData))
            {
                apiCallPath += $"&itemData={itemData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<ItemDto>(baseUrl, apiCallPath);
            return dto;
        }

        public LanguageStringsDto GetLanguageStrings(RiotApiConfig.Regions region, string locale = null, string version = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/language-strings?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/language-strings?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            //make the call
            var dto = MakeCallToRiotApi<LanguageStringsDto>(baseUrl, apiCallPath);
            return dto;
        }

        public IEnumerable<string> GetSupportedLanguages(RiotApiConfig.Regions region)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/languages?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/languages?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<IEnumerable<string>>(baseUrl, apiCallPath);
            return dto;
        }

        public MapDataDto GetMapData(RiotApiConfig.Regions region, string locale = null, string version = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/map?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/map?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            //make the call
            var dto = MakeCallToRiotApi<MapDataDto>(baseUrl, apiCallPath);
            return dto;
        }

        public MasteryListDto GetMasteryList(RiotApiConfig.Regions region, string locale = null, string version = null, string masteryListData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/mastery?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/mastery?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (!string.IsNullOrEmpty(masteryListData))
            {
                apiCallPath += $"&masteryListData={masteryListData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<MasteryListDto>(baseUrl, apiCallPath);
            return dto;
        }

        public MasteryDto GetMasteryById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string masteryData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/mastery/4214?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/mastery/{id}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (!string.IsNullOrEmpty(masteryData))
            {
                apiCallPath += $"&masteryData={masteryData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<MasteryDto>(baseUrl, apiCallPath);
            return dto;
        }

        public RealmDto GetRealmData(RiotApiConfig.Regions region)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/realm?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/realm?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<RealmDto>(baseUrl, apiCallPath);
            return dto;
        }

        public RuneListDto GetRuneList(RiotApiConfig.Regions region, string locale = null, string version = null, string runeListData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/rune?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/rune?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (!string.IsNullOrEmpty(runeListData))
            {
                apiCallPath += $"&runeListData={runeListData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<RuneListDto>(baseUrl, apiCallPath);
            return dto;
        }

        public RuneDto GetRuneById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string runeData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/rune/5235?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/rune/{id}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (!string.IsNullOrEmpty(runeData))
            {
                apiCallPath += $"&runeListData={runeData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<RuneDto>(baseUrl, apiCallPath);
            return dto;
        }

        public SummonerSpellListDto GetSummonerSpellList(RiotApiConfig.Regions region, string locale = null, string version = null,
            bool? dataById = null, string spellData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/summoner-spell?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/summoner-spell?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (dataById.HasValue)
            {
                apiCallPath += $"&dataById={dataById}";
            }
            if (!string.IsNullOrEmpty(spellData))
            {
                apiCallPath += $"&spellData={spellData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<SummonerSpellListDto>(baseUrl, apiCallPath);
            return dto;
        }

        public SummonerSpellDto GetSummonerSpellById(RiotApiConfig.Regions region, int id, string locale = null, string version = null,
            string spellData = null)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/summoner-spell/1?spellData=all&api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/summoner-spell/{id}?api_key={this.ApiKey}";
            //add additional parameters
            if (!string.IsNullOrEmpty(locale))
            {
                apiCallPath += $"&locale={locale}";
            }
            if (!string.IsNullOrEmpty(version))
            {
                apiCallPath += $"&version={version}";
            }
            if (!string.IsNullOrEmpty(spellData))
            {
                apiCallPath += $"&spellData={spellData}";
            }
            //make the call
            var dto = MakeCallToRiotApi<SummonerSpellDto>(baseUrl, apiCallPath);
            return dto;
        }

        public IEnumerable<string> GetVersionData(RiotApiConfig.Regions region)
        {
            //https://global.api.pvp.net/api/lol/static-data/eune/v1.2/versions?api_key=
            //find the appropriate end point depending the region
            var endPoint = RiotApiConfig.GetRegionalEndPointByRegion(RiotApiConfig.Regions.Global);
            //compose url
            var baseUrl = $"https://{endPoint.Host}/";
            var apiCallPath = $"api/lol/static-data/{region.ToString().ToLower()}/v1.2/versions?api_key={this.ApiKey}";
            //make the call
            var dto = MakeCallToRiotApi<IEnumerable<string>>(baseUrl, apiCallPath);
            return dto;
        }
    }
}
