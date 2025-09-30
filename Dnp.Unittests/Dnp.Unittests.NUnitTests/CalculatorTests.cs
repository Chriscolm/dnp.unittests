using Dnp.Unittests;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // --- Add ---
        [Test]
        public void Add_ShouldReturnCorrectSum()
        {            
            Assert.AreEqual(5, _calculator.Add(2, 3));
        }

        [Test]
        public void Add_ShouldHandleNegativeNumbers()
        {
            Assert.AreEqual(-1, _calculator.Add(2, -3));
        }

        [Test]
        public void Add_ShouldThrowOnOverflow()
        {
            Assert.Throws<OverflowException>(() => _calculator.Add(int.MaxValue, 1));
        }

        // --- Subtract ---
        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        { 
            Assert.AreEqual(-1, _calculator.Subtract(2, 3));
        }

        [Test]
        public void Subtract_ShouldHandleNegativeNumbers()
        {
            Assert.AreEqual(5, _calculator.Subtract(2, -3));
        }

        [Test]
        public void Subtract_ShouldThrowOnUnderflow()
        {
            Assert.Throws<OverflowException>(() => _calculator.Subtract(int.MinValue, 1));
        }

        // --- Multiply ---
        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            Assert.AreEqual(6, _calculator.Multiply(2, 3));
        }

        [Test]
        public void Multiply_WithZero_ShouldReturnZero()
        {
            Assert.AreEqual(0, _calculator.Multiply(5, 0));
        }

        [Test]
        public void Multiply_ShouldThrowOnOverflow()
        {
            Assert.Throws<OverflowException>(() => _calculator.Multiply(int.MaxValue, 2));
        }

        // --- Divide ---
        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            Assert.AreEqual(2, _calculator.Divide(6, 3));
        }

        [Test]
        public void Divide_ShouldHandleNegativeNumbers()
        {
            Assert.AreEqual(-2, _calculator.Divide(6, -3));
        }

        [Test]
        public void Divide_ByZero_ShouldThrow()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
        }

        [Test]
        public void Divide_MinValueByMinusOne_ShouldThrowOnOverflow()
        {
            Assert.Throws<OverflowException>(() => _calculator.Divide(int.MinValue, -1));
        }
    }
}
