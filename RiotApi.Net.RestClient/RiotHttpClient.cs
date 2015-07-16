using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotApi.Net.RestClient.Interfaces;

namespace RiotApi.Net.RestClient
{
    public class RiotHttpClient
    {
        private static string _apiKey;

        public RiotHttpClient(string apiKey)
        {
            _apiKey = apiKey;
        }

    }
}
