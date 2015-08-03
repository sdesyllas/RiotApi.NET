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

namespace RiotApi.Net.RestClient.Interfaces
{
    /// <summary>
    /// lol-static-data-v1.2 [BR, EUNE, EUW, KR, LAN, LAS, NA, OCE, PBE, RU, TR] 
    /// </summary>
    public interface ILolStaticData
    {
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
        ChampionListDto GetChampionList(RiotApiConfig.Regions region, bool? dataById = null, string locale = null, string version = null,
            string champData = null);

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
        ChampionDto GetChampionById(RiotApiConfig.Regions region, int id, string locale = null, string version = null, string champData = null);

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
        ItemListDto GetItemList(RiotApiConfig.Regions region, string locale = null, string version = null, string itemListData = null);

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
        ItemDto GetItemById(RiotApiConfig.Regions region, int id, string locale = null, string version = null,
            string itemData = null);

        /// <summary>
        /// Retrieve language strings data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <returns>LanguageStringsDto - This object contains language strings data.</returns>
        LanguageStringsDto GetLanguageStrings(RiotApiConfig.Regions region, string locale = null, string version = null);

        /// <summary>
        /// Retrieve supported languages data.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.</param>
        /// <returns>Return Value: List[string]</returns>
        IEnumerable<string> GetSupportedLanguages(RiotApiConfig.Regions region);

        /// <summary>
        /// Retrieve map data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">Region from which to retrieve data.<</param>
        /// <param name="locale">Locale code for returned data (e.g., en_US, es_ES). If not specified, the default locale for the region is used.</param>
        /// <param name="version">Data dragon version for returned data. If not specified, the latest version for the region is used. List of valid versions can be obtained from the /versions endpoint.</param>
        /// <returns>MapDataDto - This object contains map data.</returns>
        MapDataDto GetMapData(RiotApiConfig.Regions region, string locale = null, string version = null);

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
        MasteryListDto GetMasteryList(RiotApiConfig.Regions region, string locale = null, string version = null,
            string masteryListData = null);

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
        MasteryDto GetMasteryById(RiotApiConfig.Regions region, int id, string locale = null, string version = null,
            string masteryData = null);

        /// <summary>
        /// Retrieve realm data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region">Region corresponding to data to retrieve.</param>
        /// <returns>RealmDto - This object contains realm data.</returns>
        RealmDto GetRealmData(RiotApiConfig.Regions region);

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
        RuneListDto GetRuneList(RiotApiConfig.Regions region, string locale = null, string version = null,
            string runeListData = null);

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
        RuneDto GetRuneById(RiotApiConfig.Regions region, int id, string locale = null, string version = null,
            string runeData = null);

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
        SummonerSpellListDto GetSummonerSpellList(RiotApiConfig.Regions region, string locale = null,
            string version = null, bool? dataById = null, string spellData = null);

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
        SummonerSpellDto GetSummonerSpellById(RiotApiConfig.Regions region, int id, string locale = null,
            string version = null, string spellData = null);

        /// <summary>
        /// Retrieve version data.
        /// Rate Limit Notes
        /// Requests to this API will not be counted in your Rate Limit.
        /// </summary>
        /// <param name="region"></param>
        /// <returns>Return Value: List[string]</returns>
        IEnumerable<string> GetVersionData(RiotApiConfig.Regions region);
    }
}
