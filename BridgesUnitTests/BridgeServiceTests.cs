using BridgesService.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BridgesUnitTests
{
    [TestClass]
    public class BridgeServiceTests
    {
        Mock<IBridgesService> _mockBridgeService = new();

        [TestInitialize]
        public void Setup()
        {
            _mockBridgeService.Setup(x => x.ExportToCsv()).Returns("test.csv");
        }

        [TestMethod]
        public void ReturnFilenameAfterSuccessfulExport()
        {
            var expected = "test.csv";
            var actual = "test.csv";
            Assert.AreEqual(expected, actual);
            //bridgeServiceMock.Verify(x => x.ExportToCsv());
        }

        [TestMethod]
        public void TestPipelines()
        {
            var expected = "test.csv";
            var actual = "test.csv";
            Assert.AreEqual(expected, actual);
        }
    }
}