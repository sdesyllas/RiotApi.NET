using Moq;
using NUnit.Framework;
using RiotApi.Net.RestClient;
using RiotApi.Net.RestClient.Configuration;
using RiotApi.Net.RestClient.Dto.CurrentGame;

namespace RiotApi.Net.Tests.BehaviourTesting
{
    [TestFixture]
    public class CurrentGameBehaviour
    {
        private Mock<IRiotClient> _mockClient;

        [TestFixtureSetUp]
        public void Init()
        {
            _mockClient = new Mock<IRiotClient>();
        }

        [Test]
        public void GetCurrentGameInformationForSummonerIdBehaviour()
        {
            //Arrange
            _mockClient.Setup(x => x.CurrentGame.GetCurrentGameInformationForSummonerId(It.IsAny<RiotApiConfig.Platforms>(), It.IsAny<long>()))
                .Returns(new CurrentGameInfo());

            //Act
            IRiotClient client = _mockClient.Object;
            CurrentGameInfo dto = client.CurrentGame.GetCurrentGameInformationForSummonerId(
                RiotApiConfig.Platforms.EUN1, 1);

            //Assert
            Assert.IsInstanceOf<CurrentGameInfo>(dto);
            Assert.NotNull(dto);
        }
    }
}
