namespace TestCalculatePercentageChange
{
    [TestClass]
    public class TestCalculatePercentageChange
    {
        [TestMethod]
        public void CalculatePercentageChange_WithPositiveChange_ShouldReturnPositivePercentage()
        {
            // Arrange
            double oldPrice = 100;
            double newPrice = 110;

            // Act
            double result = PriceChangeAlert.CalculatePercentageChange(oldPrice, newPrice);

            // Assert
            Assert.AreEqual(10, result, 0.0001); // Очакваме 10% увеличение
        }

        [TestMethod]
        public void CalculatePercentageChange_WithNegativeChange_ShouldReturnNegativePercentage()
        {
            // Arrange
            double oldPrice = 100;
            double newPrice = 90;

            // Act
            double result = PriceChangeAlert.CalculatePercentageChange(oldPrice, newPrice);

            // Assert
            Assert.AreEqual(-10, result, 0.0001); // Очакваме 10% намаление
        }

        [TestMethod]
        public void CalculatePercentageChange_WithNoChange_ShouldReturnZero()
        {
            // Arrange
            double oldPrice = 100;
            double newPrice = 100;

            // Act
            double result = PriceChangeAlert.CalculatePercentageChange(oldPrice, newPrice);

            // Assert
            Assert.AreEqual(0, result, 0.0001); // Очакваме 0% промяна
        }
    }
}
