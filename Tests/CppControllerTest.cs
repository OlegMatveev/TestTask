using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using TastTask;
using TestTask;

namespace Tests
{
    [TestFixture]
    class CppControllerTest
    {
        [Test]
        public async Task ReturnsEmptyListCppTest()
        {
            // Arrange
            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
            List<string> filesList = new List<string>();
            scanner.Setup(s => s.GetFilesList(It.IsAny<string>(), It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

            CppController controller = new CppController();
            int count;
            int expectedValue = 0;

            // Act

            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);
            count = returnedList.Count;

            // Assert
            Assert.AreEqual(expectedValue, count);
        }

        [Test]
        public async Task ReturnsNotEmptyListCppTest()
        {
            // Arrange
            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
            List<string> filesList = new List<string>() { "C:\\asd.cpp", "C:\\qwe.cpp" };
            scanner.Setup(s => s.GetFilesList(It.IsAny<string>(), It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

            CppController controller = new CppController();
            int expectedValue = 2;
            int count;

            // Act

            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);
            count = returnedList.Count;

            // Assert
            Assert.AreEqual(expectedValue, count);
        }

        [Test]
        public async Task ReturnsCorrectNamesCppTest()
        {
            // Arrange
            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
            List<string> filesList = new List<string>() { "C:\\asd.cpp", "C:\\Folder\\qwe.cpp" };
            scanner.Setup(s => s.GetFilesList(It.IsAny<string>(), It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

            CppController controller = new CppController();
            List<string> correctList = new List<string> { "asd.cpp /", "Folder\\qwe.cpp /" };

            // Act

            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);

            // Assert
            Assert.AreEqual(correctList, returnedList);
        }
    }
}
