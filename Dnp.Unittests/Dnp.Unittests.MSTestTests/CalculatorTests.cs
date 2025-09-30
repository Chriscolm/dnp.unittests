namespace Dnp.Unittests.MSTestTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


[TestClass]
public class CalculatorTests
{
    private ICalculator calculator;

    [TestInitialize]
    public void Setup()
    {
        calculator = new Calculator();
    }

    // --- Add ---
    [TestMethod]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.AreEqual(5, calculator.Add(2, 3));
    }

    [TestMethod]
    public void Add_WithMaxInt_ShouldThrowOverflowException()
    {
        Assert.ThrowsException<OverflowException>(() => calculator.Add(int.MaxValue, 1));
    }

    [TestMethod]
    public void Add_WithMinInt_ShouldReturnCorrectResult()
    {
        Assert.AreEqual(-1, calculator.Add(int.MinValue, int.MaxValue));
    }

    // --- Subtract ---
    [TestMethod]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        Assert.AreEqual(1, calculator.Subtract(4, 3));
    }

    [TestMethod]
    public void Subtract_WithMinInt_ShouldThrowOverflowException()
    {
        Assert.ThrowsException<OverflowException>(() => calculator.Subtract(int.MinValue, 1));
    }

    // --- Multiply ---
    [TestMethod]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        Assert.AreEqual(6, calculator.Multiply(2, 3));
    }

    [TestMethod]
    public void Multiply_WithOverflow_ShouldThrowOverflowException()
    {
        Assert.ThrowsException<OverflowException>(() => calculator.Multiply(int.MaxValue, 2));
    }

    [TestMethod]
    public void Multiply_WithZero_ShouldReturnZero()
    {
        Assert.AreEqual(0, calculator.Multiply(0, int.MaxValue));
    }

    // --- Divide ---
    [TestMethod]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        Assert.AreEqual(2, calculator.Divide(6, 3));
    }

    [TestMethod]
    public void Divide_ByZero_ShouldThrowDivideByZeroException()
    {
        Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(5, 0));
    }

    [TestMethod]
    public void Divide_MinIntByMinusOne_ShouldThrowOverflowException()
    {
        Assert.ThrowsException<OverflowException>(() => calculator.Divide(int.MinValue, -1));
    }
}