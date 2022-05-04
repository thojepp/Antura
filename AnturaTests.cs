using Microsoft.VisualStudio.TestTools.UnitTesting;
using Antura;

namespace AnturaProgUnitTests
{
    /// <summary>
    /// Tests for the Antura programming test
    /// </summary>
    /// <owner>Thomas Jeppsson</owner>
    [TestClass]
    public class AnturaTests
    {
        /// <summary>
        /// Counts the keys in string with valid string.
        /// </summary>
        [TestMethod]
        public void CountKeysInString_WithValidString()
        {
            //
            // Arrange
            //
            string inputString = "test3 test3test3test3apa apa bpa test3";
            string searchKey = "test3";
            int expectedCount = 5;
            AnturaProgTest anturaProgTest = new AnturaProgTest();

            //
            // Act
            //
            int receivedCount = anturaProgTest.CountKeysInString(inputString, searchKey);

            //
            // Assert
            //
            Assert.AreEqual(expectedCount, receivedCount, "The key count are not the same");
        }
    }
}
