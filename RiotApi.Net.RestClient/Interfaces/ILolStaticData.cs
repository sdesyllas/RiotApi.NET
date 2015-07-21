using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using RiotApi.Net.RestClient.Dto.LolStaticData.Item;

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
        ChampionListDto GetChampionList(RiotApiConfig.Regions region, bool dataById = false, string locale = "en_US", string version = "",
            string champData = "all");

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
        ChampionDto GetChampionById(RiotApiConfig.Regions region, int id, string locale = "en_US", string version = "", string champData = "all");

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
        ItemListDto GetItemList(RiotApiConfig.Regions region, string locale = "en_US", string version = "", string itemListData = "all");

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
        /// <returns></returns>
        ItemDto GetItemById(RiotApiConfig.Regions region, int id, string locale = "en_US", string version = "",
            string itemData = "all");
    }
}
