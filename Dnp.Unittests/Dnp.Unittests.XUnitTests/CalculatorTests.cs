namespace Dnp.Unittests.XUnitTests
{
    /// <summary>
    /// Test generiert von Github Copilot<br />
    /// Prompt: Schreibe Unit-Tests für die Klasse Calculator.cs. Schließe Grenzfälle mit ein und beachte ebenfalls, dass bestimmte Werte zu Exceptions führen können. Benutze xunit als testframework
    /// </summary>
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, -2, -3)]
        [InlineData(int.MaxValue, 0, int.MaxValue)]
        [InlineData(int.MinValue, 0, int.MinValue)]
        public void Add_ReturnsExpectedResult(int a, int b, int expected)
        {
            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-1, -2, 1)]
        [InlineData(int.MaxValue, 1, int.MaxValue - 1)]
        public void Subtract_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, 3, -6)]
        [InlineData(0, 100, 0)]
        [InlineData(int.MaxValue, 1, int.MaxValue)]
        public void Multiply_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-6, 3, -2)]
        [InlineData(0, 1, 0)]
        public void Divide_ReturnsExpectedResult(int a, int b, int expected)
        {
            var result = _calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
        }
    }
}