using System.Collections.Generic;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TastTask;
using TestTask;
using TestTask.Interfaces;

namespace Tests
{
    [TestFixture]
    public class AllControllerTest
    {

        [Test]
        public async Task ReturnsEmptyList()
        {
            // Arrange
            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
            List<string> filesList = new List<string>();
            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

            Mock<IConverter> converter = new Mock<IConverter>();
            converter.Setup(s => s.ConvertList(It.IsAny<List<string>>(), It.IsAny<string>())).Returns(filesList);

            AllController controller = new AllController();

            int expectedValue = 0;
            int count;

            // Act

            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object, converter.Object);
            count = returnedList.Count;            

            // Assert
            Assert.AreEqual(expectedValue, count);
        }

        [Test]
        public async Task ReturnsNotEmptyList()
        {
            // Arrange
            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
            List<string> filesList = new List<string>() { "C:\\asd.txt", "C:\\qwe.cpp" };
            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

            Mock<IConverter> converter = new Mock<IConverter>();
            converter.Setup(s => s.ConvertList(It.IsAny<List<string>>(), It.IsAny<string>())).Returns(filesList);

            AllController controller = new AllController();

            int expectedValue = 2;
            int count;

            // Act

            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object, converter.Object);
            count = returnedList.Count;

            // Assert
            Assert.AreEqual(expectedValue, count);
        }

        //[Test]
        //public async Task ReturnsCorrectNames()
        //{
        //    // Arrange
        //    Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
        //    List<string> filesList = new List<string>() { "C:\\asd.txt", "C:\\qwe.cpp" };
        //    scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

        //    AllController controller = new AllController();
        //    List<string> correctList = new List<string> { "asd.txt", "qwe.cpp" };

        //    // Act

        //    List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);

        //    // Assert
        //    Assert.AreEqual(correctList, returnedList);
        //}

    }
}
