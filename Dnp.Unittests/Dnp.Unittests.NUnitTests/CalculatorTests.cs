namespace Dnp.Unittests.NUnitTests;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [TestCase(1, 2, 3)]
    [TestCase(-1, -2, -3)]
    [TestCase(int.MaxValue, 0, int.MaxValue)]
    [TestCase(int.MinValue, 0, int.MinValue)]
    public void Add_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.That(_calculator.Add(a, b), Is.EqualTo(expected));
    }

    [TestCase(5, 3, 2)]
    [TestCase(-5, -3, -2)]
    [TestCase(int.MaxValue, 1, int.MaxValue - 1)]
    [TestCase(int.MinValue, 1, int.MinValue + 1)]
    public void Subtract_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.That(_calculator.Subtract(a, b), Is.EqualTo(expected));
    }

    [TestCase(2, 3, 6)]
    [TestCase(-2, 3, -6)]
    [TestCase(0, 100, 0)]
    [TestCase(int.MaxValue, 1, int.MaxValue)]
    public void Multiply_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.That(_calculator.Multiply(a, b), Is.EqualTo(expected));
    }

    [TestCase(6, 3, 2)]
    [TestCase(-6, 3, -2)]
    [TestCase(0, 1, 0)]
    public void Divide_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.That(_calculator.Divide(a, b), Is.EqualTo(expected));
    }

    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1, 0));
    }
}
