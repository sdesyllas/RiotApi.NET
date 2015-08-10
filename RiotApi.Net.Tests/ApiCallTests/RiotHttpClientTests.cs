using System;
using System.Configuration;
using System.Linq;
using Ninject;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Helpers;
using RiotApi.Net.RestClient.NinjectModules;

namespace RiotApi.Net.Tests.ApiCallTests
{
    [TestFixture]
    public class RiotHttpClientTests
    {

        [Test]
        public void GetAllChampions()
        {
            var dto = GlobalSetup.RiotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.EUNE);
            Assert.NotNull(dto);
            Assert.Greater(dto.Champions.Count(), 0);
            foreach (var championDto in dto.Champions)
            {
                Console.WriteLine(championDto.ToString());
            }
        }

        [Test]
        public void GetChampionById()
        {
            var dto = GlobalSetup.RiotClient.Champion.RetrieveChampionById(RiotApiConfig.Regions.EUNE, 1);
            Assert.NotNull(dto);
            Assert.AreEqual(1, dto.Id);
            Console.WriteLine(dto.ToString());
        }

        [Test]
        [ExpectedException(typeof(RiotExceptionRaiser.RiotApiException))]
        public void TestUnauthorized()
        {
            //initialize riot http client with your riot api key
            IRiotClient riotClient = new RiotHttpClient("your api key here");
            //retrieve all current free to play champions
            var championList = riotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay: true);
            //print the number of free to play champions
            Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
        }

        [Test]
        public void TestNinject()
        {
            //initialize riot client injecting http module with your riot api key
            IKernel kernel = new StandardKernel(new RiotHttpClientModule(ConfigurationManager.AppSettings["ApiKey"]));
            var riotClient = kernel.Get<RiotHttpClient>();
            //retrieve all current free to play champions
            var championList = riotClient.Champion.RetrieveAllChampions(RiotApiConfig.Regions.NA, freeToPlay: true);
            //print the number of free to play champions
            Console.WriteLine($"There are {championList.Champions.Count()} free to play champions to play with!");
        }
    }
}