
namespace TestIsDifference_methods
{
    [TestClass]
    public class PriceChangeAlertTests
    {
        [TestMethod]
        public void IsSignificantChange_WithDifferenceGreaterThanThreshold_ShouldReturnTrue()
        {
            // Arrange
            double threshold = 10;
            double change = 15;

            // Act
            bool result = PriceChangeAlert.IsSignificantChange(change, threshold);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsSignificantChange_WithDifferenceLessThanThreshold_ShouldReturnFalse()
        {
            // Arrange
            double threshold = 10;
            double change = 5;

            // Act
            bool result = PriceChangeAlert.IsSignificantChange(change, threshold);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsSignificantChange_WithDifferenceEqualToThreshold_ShouldReturnTrue()
        {
            // Arrange
            double threshold = 10;
            double change = 10;

            // Act
            bool result = PriceChangeAlert.IsSignificantChange(change, threshold);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
