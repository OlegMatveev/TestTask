using NUnit.Framework;
using TastTask;
using TastTask.Interfaces;
using TestTask;

namespace Tests
{
    [TestFixture]
    class CreatorTest
    {
        [Test]
        public void ReturnedAllControllerTest()
        {
            // Arrange
            Creator creator = new Creator();
            IController testController;
            AllController expected = new AllController();

            // Act
            testController = creator.GetController("all");

            // Assert
            Assert.IsInstanceOf(expected.GetType(), testController);
        }

        [Test]
        public void ReturnedCppControllerTest()
        {
            // Arrange
            Creator creator = new Creator();
            IController testController;
            CppController expected = new CppController();

            // Act
            testController = creator.GetController(".cpp");

            // Assert
            Assert.IsInstanceOf(expected.GetType(), testController);
        }

        [Test]
        public void ReturnedReversControllerTest()
        {
            // Arrange
            Creator creator = new Creator();
            IController testController;
            ReversController expected = new ReversController();

            // Act
            testController = creator.GetController("reversed1");

            // Assert
            Assert.IsInstanceOf(expected.GetType(), testController);
        }

        [Test]
        public void ReturnedRevers2ControllerTest()
        {
            // Arrange
            Creator creator = new Creator();
            IController testController;
            Revers2Controller expected = new Revers2Controller();

            // Act
            testController = creator.GetController("reversed2");

            // Assert
            Assert.IsInstanceOf(expected.GetType(), testController);
        }

        [Test]
        public void ReturnedWriterTest()
        {
            // Arrange
            Creator creator = new Creator();
            IWriter writerTest;
            Writer expWr = new Writer();            

            // Act
            writerTest = creator.GetWriter();

            // Assert
            Assert.IsInstanceOf(expWr.GetType(), writerTest);
        }

        [Test]
        public void ReturnedFolderScannerTest()
        {
            // Arrange
            Creator creator = new Creator();
            IFolderScanner scannerTest;
            FolderScanner expScanner = new FolderScanner();

            // Act
            scannerTest = creator.GetScanner();

            // Assert
            Assert.IsInstanceOf(expScanner.GetType(), scannerTest);
        }
    }
}
