using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.LolStaticData.Champion;
using RiotApi.Net.RestClient.Dto.Summoner;
using ChampionListDto = RiotApi.Net.RestClient.Dto.Champion.ChampionListDto;

namespace RiotApi.Net.Tests.BehaviourTesting
{
    public class ChampionBehaviour
    {
        private Mock<IRiotClient> _mockClient;

        [TestFixtureSetUp]
        public void Init()
        {
            _mockClient = new Mock<IRiotClient>();
        }

        [Test]
        public void RetrieveAllChampionsBehaviour()
        {
            _mockClient.Setup(x => x.Champion.RetrieveAllChampions(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<bool>()))
                .Returns(new ChampionListDto());
            IRiotClient client = _mockClient.Object;
            ChampionListDto dto = client.Champion.RetrieveAllChampions(RiotApiConfig.Regions.EUNE, true);
            Assert.IsInstanceOf<ChampionListDto>(dto);
        }

        [Test]
        public void RetrieveChampionByIdBehaviour()
        {
            _mockClient.Setup(x => x.Champion.RetrieveChampionById(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<int>()))
                .Returns(new ChampionListDto.ChampionDto());
            IRiotClient client = _mockClient.Object;
            ChampionListDto.ChampionDto dto = client.Champion.RetrieveChampionById(RiotApiConfig.Regions.EUNE, 1);
            Assert.IsInstanceOf<ChampionListDto.ChampionDto>(dto);
        }
    }
}
