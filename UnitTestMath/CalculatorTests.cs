using MathPractice;

namespace UnitTestMath
{
    [TestClass]
    public sealed class CalculatorTests
    {
        // Todo: naam conventies voor testmethodes
        // Todo: code coverage packaged
        [TestMethod]
        [DataRow(1, 3, 4)]
        [DataRow(0, 0, 0)]
        [DataRow(-2, -4, -6)]
        public void TestSum(int a, int b, int expectedResult)
        {
            // Arrange
            Calculator calculation = new Calculator();

            // Act
            int result = calculation.Sum(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(5, 3, 2)]
        [DataRow(0, 0, 0)]
        [DataRow(3, 5, -2)]
        [DataRow(-2, -4, 2)]
        public void TestSubtract(int a, int b, int expectedResult)
        {
            // Arrange
            Calculator calculation = new Calculator();

            // Act
            int result = calculation.Subtract(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(0, 0, 0)]
        [DataRow(-2, -4, 8)]
        [DataRow(2, -4, -8)]
        public void TestMultiply(int a, int b, int expectedResult)
        {
            // Arrange
            Calculator calculation = new Calculator();

            // Act
            int result = calculation.Multiply(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
