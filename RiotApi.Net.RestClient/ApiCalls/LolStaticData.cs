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
    /// <summary>
    /// lol-static-data-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public class LolStaticData: GenericRiotCaller, ILolStaticData
    {
        public LolStaticData(string apiKey)
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Riot Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Retrieves champion list.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the champData parameter for more information.
        /// </summary>
        /// <param name="region">The region of the leagues.</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="dataById">If specified as true, the returned data map will use the champions' IDs as the keys. If not specified or specified as false, the returned data map will use the champions' keys instead.</param>
        /// <param name="champData">Tags to return additional data. Only type, version, data, id, key, name, and title are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>ChampionListDto - This object contains champion list data.</returns>
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

        /// <summary>
        /// Retrieves a champion by its id.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the champData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="id">Champion ID</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="champData">Tags to return additional data. Only id, key, name, and title are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Retrieves item list.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the itemListData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="itemListData">Tags to return additional data. Only type, version, basic, data, id, name, plaintext, group, and description are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>ItemListDto - This object contains item list data.</returns>
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

        /// <summary>
        /// Retrieves item by its unique id.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the itemData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="id">Item ID</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="itemData">Tags to return additional data. Only id, name, plaintext, group, and description are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>ItemDto - This object contains item data.</returns>
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

        /// <summary>
        /// Retrieve language strings data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <returns>LanguageStringsDto - This object contains language strings data.</returns>
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

        /// <summary>
        /// Retrieve supported languages data.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <returns>Return Value: List[string]</returns>
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

        /// <summary>
        /// Retrieve map data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.<</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <returns>MapDataDto - This object contains map data.</returns>
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

        /// <summary>
        /// Retrieves mastery list.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the masteryListData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="masteryListData">Tags to return additional data. Only type, version, data, id, name, and description are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>MasteryListDto - This object contains mastery list data.</returns>
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

        /// <summary>
        /// Retrieves mastery item by its unique id.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the masteryData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="id">Mastery ID</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="masteryData">Tags to return additional data. Only id, name, and description are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>MasteryDto - This object contains mastery data.</returns>
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

        /// <summary>
        /// Retrieve realm data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">Region corresponding to data to retrieve.</param>
        /// <returns>RealmDto - This object contains realm data.</returns>
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

        /// <summary>
        /// Retrieves rune list.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the runeListData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="runeListData">Tags to return additional data. Only type, version, data, id, name, rune, and description are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>RuneListDto - This object contains rune list data.</returns>
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

        /// <summary>
        /// Retrieves rune by its unique id.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        ///  Not all data specified below is returned by default. See the runeData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="id">Rune ID</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="runeData">Tags to return additional data. Only id, name, rune, and description are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>RuneDto - This object contains rune data.</returns>
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

        /// <summary>
        /// Retrieves summoner spell list.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the spellData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="dataById">If specified as true, the returned data map will use the spells' IDs as the keys. If not specified or specified as false, the returned data map will use the spells' keys instead.</param>
        /// <param name="spellData">Tags to return additional data. Only type, version, data, id, key, name, description, and summonerLevel are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>SummonerSpellListDto - This object contains summoner spell list data.</returns>
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

        /// <summary>
        /// Retrieves summoner spell by its unique id.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// Implementation Notes
        /// Not all data specified below is returned by default. See the spellData parameter for more information.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="id">Summoner spell ID</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <param name="spellData">Tags to return additional data. Only id, key, name, description, and summonerLevel are returned by default if this parameter isn't specified. To return all additional data, use the tag 'all'.</param>
        /// <returns>SummonerSpellDto - This object contains summoner spell data.</returns>
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

        /// <summary>
        /// Retrieve version data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region"></param>
        /// <returns>Return Value: List[string]</returns>
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
