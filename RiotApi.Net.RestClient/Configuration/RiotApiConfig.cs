using System.Collections.Generic;
using System.Linq;

namespace RiotApi.Net.RestClient.Configuration
{
    public static class RiotApiConfig
    {
        public static RegionalEndPoint GetRegionalEndPointByRegion(Regions region)
        {
            return RegionalEndPoints.FirstOrDefault(x => x.Region == region.ToString());
        }

        /// <summary>
        /// REGIONAL ENDPOINTS --readonly--    
        /// * Note: The static data is a global service, and thus uses the global.api.pvp.net endpoint regardless of the region selected. 
        /// https://developer.riotgames.com/docs/regional-endpoints
        /// </summary>
        public static readonly IEnumerable<RegionalEndPoint> RegionalEndPoints = new List<RegionalEndPoint>()
        {
          new RegionalEndPoint {Region = "BR", PlatformId = "BR1",  Host = "br.api.pvp.net"} ,
          new RegionalEndPoint {Region = "EUNE", PlatformId = "EUN1",  Host = "eune.api.pvp.net"} ,
          new RegionalEndPoint {Region = "EUW", PlatformId = "EUW1",  Host = "euw.api.pvp.net"} ,
          new RegionalEndPoint {Region = "KR", PlatformId = "KR",  Host = "kr.api.pvp.net"} ,
          new RegionalEndPoint {Region = "LAN", PlatformId = "LA1",  Host = "lan.api.pvp.net"} ,
          new RegionalEndPoint {Region = "LAS", PlatformId = "LA2",  Host = "las.api.pvp.net"} ,
          new RegionalEndPoint {Region = "NA", PlatformId = "NA1",  Host = "na.api.pvp.net"} ,
          new RegionalEndPoint {Region = "OCE", PlatformId = "OC1",  Host = "oce.api.pvp.net"} ,
          new RegionalEndPoint {Region = "TR", PlatformId = "TR1",  Host = "tr.api.pvp.net"} ,
          new RegionalEndPoint {Region = "RU", PlatformId = "RU",  Host = "ru.api.pvp.net"} ,
          new RegionalEndPoint {Region = "PBE", PlatformId = "PBE1",  Host = "pbe.api.pvp.net"} ,
          new RegionalEndPoint {Region = "Global", PlatformId = "",  Host = "global.api.pvp.net"}
        };


        #region Config Entities
        public class RegionalEndPoint
        {
            public string Region { get; set; }
            public string PlatformId { get; set; }
            public string Host { get; set; }
        }
        #endregion

        public enum Regions
        {
            BR,
            EUNE,
            EUW,
            KR,
            LAN,
            LAS,
            NA,
            OCE,
            TR,
            RU,
            PBE,
            Global
        }

        public enum Platforms
        {
            BR1,
            EUN1,
            EUW1,
            KR,
            LA1,
            LA2,
            NA1,
            OC1,
            TR1,
            RU,
            PBE1
        }
    }
}
