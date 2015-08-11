using System;
using System.Configuration;
using Ninject;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.NinjectModules;

namespace RiotApi.Net.Tests
{
    [SetUpFixture]
    public class GlobalSetup
    {
        public static IRiotClient RiotHttpClient { get; set; }

        [SetUp]
        public void GlueNinjectModules()
        {
            RiotHttpClient = RiotApiLoader.CreateHttpClient(ConfigurationManager.AppSettings["ApiKey"]);
        }
    }
}
