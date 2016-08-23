using NUnit.Framework;
using System.Collections.Generic;
using TestTask.Converters;

namespace Tests
{
    [TestFixture]
    class AllConverterTest
    {
        [Test]
        public void AllConverterReturnsCorrectName()
        {
            // Arrange
            List<string> filesList = new List<string>() { "C:\\asd.txt", "C:\\Folder\\qwe.cpp" };
            List<string> expectedList = new List<string> { "asd.txt", "Folder\\qwe.cpp" };
            string path = "c:\\";

            AllConverter convert = new AllConverter();
            List<string> actualList = new List<string>();

            // Act
            actualList = convert.ConvertList(filesList, path);

            // Assert
            Assert.AreEqual(expectedList, actualList);

        }
    }
}
