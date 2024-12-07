using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PriceChangeAlert;

namespace UnitTest_IsDifference
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsThereDifference_WithDifferenceGreaterThanThreshold_ShouldReturnTrue()
        {
            // Arrange
            double threshold = 10;
            double difference = 15;

            // Act
            bool result = PriceChangeAlert.IsThereDifference(threshold, difference);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
