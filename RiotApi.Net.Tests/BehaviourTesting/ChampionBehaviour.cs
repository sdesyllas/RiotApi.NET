using Moq;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using ChampionListDto = RiotApi.Net.RestClient.Dto.Champion.ChampionListDto;

namespace RiotApi.Net.Tests.BehaviourTesting
{
    [TestFixture]
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
            //Arrange
            _mockClient.Setup(x => x.Champion.RetrieveAllChampions(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<bool>()))
                .Returns(new ChampionListDto());

            //Act
            IRiotClient client = _mockClient.Object;
            ChampionListDto dto = client.Champion.RetrieveAllChampions(RiotApiConfig.Regions.EUNE, true);

            //Assert
            Assert.IsInstanceOf<ChampionListDto>(dto);
            Assert.NotNull(dto);
        }

        [Test]
        public void RetrieveChampionByIdBehaviour()
        {
            //Arrange
            _mockClient.Setup(x => x.Champion.RetrieveChampionById(It.IsAny<RiotApiConfig.Regions>(), It.IsAny<int>()))
                .Returns(new ChampionListDto.ChampionDto());

            //Act
            IRiotClient client = _mockClient.Object;
            ChampionListDto.ChampionDto dto = client.Champion.RetrieveChampionById(RiotApiConfig.Regions.EUNE, 8);

            //Assert
            Assert.IsInstanceOf<ChampionListDto.ChampionDto>(dto);
            Assert.NotNull(dto);
        }
    }
}
