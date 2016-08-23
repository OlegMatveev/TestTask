//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Moq;
//using NUnit.Framework;
//using TastTask;
//using TestTask;

//namespace Tests
//{
//    [TestFixture]
//    class Revers2ControllerTest
//    {
//        [Test]
//        public async Task ReturnsEmptyListRevers2()
//        {
//            // Arrange
//            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
//            List<string> filesList = new List<string>();
//            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

//            Revers2Controller controller = new Revers2Controller();

//            int expectedValue = 0;
//            int count;

//            // Act

//            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);
//            count = returnedList.Count;

//            // Assert
//            Assert.AreEqual(expectedValue, count);
//        }

//        [Test]
//        public async Task ReturnsNotEmptyListRevers2()
//        {
//            // Arrange
//            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
//            List<string> filesList = new List<string>() { "C:\\asd.txt", "C:\\qwe.cpp" };
//            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

//            Revers2Controller controller = new Revers2Controller();

//            int expectedValue = 2;
//            int count;

//            // Act

//            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);
//            count = returnedList.Count;

//            // Assert
//            Assert.AreEqual(expectedValue, count);
//        }

//        [Test]
//        public async Task ReturnsCorrectNamesRevers2()
//        {
//            // Arrange
//            Mock<IFolderScanner> scanner = new Mock<IFolderScanner>();
//            List<string> filesList = new List<string>() { "C:\\asd.txt", "C:\\Folder1\\Folder2\\qwe.cpp", "C:\\User\\zxc.jpg" };
//            scanner.Setup(s => s.GetFilesList(It.IsAny<string>())).Returns(async () => await Task.Run(() => filesList));

//            Revers2Controller controller = new Revers2Controller();
//            List<string> correctList = new List<string> { "txt.dsa", "ppc.ewq\\2redloF\\1redloF", "gpj.cxz\\resU" };

//            // Act

//            List<string> returnedList = await controller.CheckPath("c:\\", scanner.Object);

//            // Assert
//            Assert.AreEqual(correctList, returnedList);
//        }
//    }
//}
