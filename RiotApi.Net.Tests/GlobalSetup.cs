using System;
using System.Configuration;
using Ninject;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.Tests.NinjectModules;

namespace RiotApi.Net.Tests
{
    [SetUpFixture]
    public class GlobalSetup
    {
        public static IRiotClient RiotHttpClient { get; set; }

        [SetUp]
        public void GlueNinjectModules()
        {
            //load a Riot Http module with an Api key into your kernel of your app
            IKernel kernel = new StandardKernel(new RiotHttpClientModule(ConfigurationManager.AppSettings["ApiKey"]));
            //get back the riot client from your application kernel using ninject
            RiotHttpClient = kernel.Get<RiotClient>();
        }
    }
}
