//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Moq;
//using NUnit.Framework;
//using TastTask;
//using TestTask;

//namespace Tests
//{
//    [TestFixture]
//    class ReversControllerTest
//    {
//        [Test]
//        public async Task ReturnsEmptyListRevers()
//        {
//            // Arrange

//            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
//            List<string> filesList = new List<string>();
//            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

//            ReversController controller = new ReversController();

//            int expectedValue = 0;
//            int count;

//            // Act

//            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);
//            count = returnedList.Count;

//            // Assert
//            Assert.AreEqual(expectedValue, count);
//        }

//        [Test]
//        public async Task ReturnsNotEmptyListRevers()
//        {
//            // Arrange

//            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
//            List<string> filesList = new List<string>() { "C:\\asd.txt", "C:\\qwe.cpp"  };
//            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

//            ReversController controller = new ReversController();

//            int expectedValue = 2;
//            int count;

//            // Act

//            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);
//            count = returnedList.Count;

//            // Assert
//            Assert.AreEqual(expectedValue, count);
//        }

//        [Test]
//        public async Task ReturnsCorrectNamesRevers()
//        {
//            // Arrange

//            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
//            List<string> filesList = new List<string>() { "C:\\asd.txt", "C:\\Folder1\\Folder2\\qwe.cpp", "C:\\User\\zxc.jpg" };
//            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

//            ReversController controller = new ReversController();
//            List<string> correctList = new List<string> { "asd.txt", "qwe.cpp\\Folder2\\Folder1", "zxc.jpg\\User" };

//            // Act

//            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);

//            // Assert
//            Assert.AreEqual(correctList, returnedList);
//        }
//    }
//}
