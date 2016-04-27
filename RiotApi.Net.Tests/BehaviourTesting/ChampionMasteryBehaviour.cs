using Moq;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.ChampionMastery;
using System.Collections.Generic;

namespace RiotApi.Net.Tests.BehaviourTesting
{

    [TestFixture]
    public class ChampionMasteryBehaviour
    {
        private Mock<IRiotClient> _mockClient;

        [TestFixtureSetUp]
        public void Init()
        {
            _mockClient = new Mock<IRiotClient>();
        }

        [Test]
        public void RetrieveChampionMasteryByIDBehaviour()
        {
            //Arrange
            _mockClient.Setup(x => x.ChampionMastery.RetrieveChampionMasteryByID(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<long>(), It.IsAny<long>()))
                .Returns(new ChampionMasteryDto());

            //Act
            IRiotClient client = _mockClient.Object;
            ChampionMasteryDto dto = client.ChampionMastery.RetrieveChampionMasteryByID(RiotApiConfig.Regions.NA, 1, 1);

            //Assert
            Assert.IsInstanceOf<ChampionMasteryDto>(dto);
            Assert.NotNull(dto);
        }

        [Test]
        public void RetrieveChampionMasteriesByPlayerIdBehaviour()
        {
            //Arrange
            _mockClient.Setup(x => x.ChampionMastery.RetrieveChampionMasteriesByPlayerId(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<long>()))
                .Returns(new List<ChampionMasteryDto>());

            //Act
            IRiotClient client = _mockClient.Object;
            List<ChampionMasteryDto> dtoList = (List < ChampionMasteryDto > )client.ChampionMastery.RetrieveChampionMasteriesByPlayerId(RiotApiConfig.Regions.NA, 1);

            //Assert
            Assert.IsInstanceOf<List<ChampionMasteryDto>>(dtoList);
            Assert.NotNull(dtoList);
        }

        [Test]
        public void RetrieveChampionMasterScoreBehaviour()
        {
            //Arrange
            _mockClient.Setup(x => x.ChampionMastery.RetrieveChampionMasterScore(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<long>()))
                .Returns(1);

            //Act
            IRiotClient client = _mockClient.Object;
            int score = client.ChampionMastery.RetrieveChampionMasterScore(RiotApiConfig.Regions.NA, 1);

            //Assert
            Assert.AreEqual(1, score);
        }

        [Test]
        public void RetrieveTopChampionsBehaviour()
        {
            //Arrange
            _mockClient.Setup(x => x.ChampionMastery.RetrieveTopChampions(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<long>(), It.IsAny<int>()))
                .Returns(new List<ChampionMasteryDto>());

            //Act
            IRiotClient client = _mockClient.Object;
            List<ChampionMasteryDto> dtoList = (List<ChampionMasteryDto>)client.ChampionMastery.RetrieveTopChampions(RiotApiConfig.Regions.NA, 1,null);

            //Assert
            Assert.IsInstanceOf<List<ChampionMasteryDto>>(dtoList);
            Assert.NotNull(dtoList);
        }
    }
}
