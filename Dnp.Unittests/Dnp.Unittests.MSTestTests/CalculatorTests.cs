namespace Dnp.Unittests.MSTestTests;

[TestClass]
public class CalculatorTests
{
    private Calculator _calculator;

    [TestInitialize]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [DataTestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(-1, -2, -3)]
    [DataRow(int.MaxValue, 0, int.MaxValue)]
    [DataRow(int.MinValue, 0, int.MinValue)]
    public void Add_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Add(a, b));
    }

    [DataTestMethod]
    [DataRow(5, 3, 2)]
    [DataRow(-5, -3, -2)]
    [DataRow(int.MaxValue, 1, int.MaxValue - 1)]
    [DataRow(int.MinValue, 1, int.MinValue + 1)]
    public void Subtract_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Subtract(a, b));
    }

    [DataTestMethod]
    [DataRow(2, 3, 6)]
    [DataRow(-2, 3, -6)]
    [DataRow(0, 100, 0)]
    [DataRow(int.MaxValue, 1, int.MaxValue)]
    public void Multiply_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Multiply(a, b));
    }

    [DataTestMethod]
    [DataRow(6, 3, 2)]
    [DataRow(-6, 3, -2)]
    [DataRow(0, 1, 0)]
    public void Divide_ReturnsExpectedResult(int a, int b, int expected)
    {
        Assert.AreEqual(expected, _calculator.Divide(a, b));
    }

    [TestMethod]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(1, 0));
    }
}
