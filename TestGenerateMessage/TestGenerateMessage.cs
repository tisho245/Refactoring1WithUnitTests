namespace TestGenerateMessage
{
    [TestClass]
    public class TestGenerateMessage
    {
        [TestMethod]
        public void GenerateMessage_WithNoChange_ShouldReturnNoChangeMessage()
        {
            // Arrange
            double current = 100;
            double last = 100;
            double change = 0;
            bool isSignificant = false;

            // Act
            string result = PriceChangeAlert.GenerateMessage(current, last, change, isSignificant);

            // Assert
            Assert.AreEqual("NO CHANGE: 100", result);
        }

        [TestMethod]
        public void GenerateMessage_WithMinorChange_ShouldReturnMinorChangeMessage()
        {
            // Arrange
            double current = 105;
            double last = 100;
            double change = 5;
            bool isSignificant = false;

            // Act
            string result = PriceChangeAlert.GenerateMessage(current, last, change, isSignificant);

            // Assert
            Assert.AreEqual("MINOR CHANGE: 100 to 105 (5.00%)", result);
        }

        [TestMethod]
        public void GenerateMessage_WithPriceUp_ShouldReturnPriceUpMessage()
        {
            // Arrange
            double current = 110;
            double last = 100;
            double change = 10;
            bool isSignificant = true;

            // Act
            string result = PriceChangeAlert.GenerateMessage(current, last, change, isSignificant);

            // Assert
            Assert.AreEqual("PRICE UP: 100 to 110 (10.00%)", result);
        }

        [TestMethod]
        public void GenerateMessage_WithPriceDown_ShouldReturnPriceDownMessage()
        {
            // Arrange
            double current = 90;
            double last = 100;
            double change = -10;
            bool isSignificant = true;

            // Act
            string result = PriceChangeAlert.GenerateMessage(current, last, change, isSignificant);

            // Assert
            Assert.AreEqual("PRICE DOWN: 100 to 90 (-10.00%)", result);
        }
    }
}