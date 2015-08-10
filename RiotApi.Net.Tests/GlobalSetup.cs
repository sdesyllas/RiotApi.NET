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
        public static IRiotClient RiotClient { get; set; }

        [SetUp]
        public void GlueNinjectModules()
        {
            
            IKernel kernel = new StandardKernel(new RiotHttpClientModule(ConfigurationManager.AppSettings["ApiKey"]));
            RiotClient = kernel.Get<RiotHttpClient>();
        }
    }
}
