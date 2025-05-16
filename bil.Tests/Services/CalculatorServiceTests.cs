using System;
using Xunit;
using bil.Services;

namespace bil.Tests.Services
{
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculator;

        public CalculatorServiceTests()
        {
            _calculator = new CalculatorService();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 7;
            
            // Act
            int result = _calculator.Add(a, b);
            
            // Assert
            Assert.Equal(12, result);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, -8, 3)]
        public void Subtract_ShouldReturnCorrectDifference(int expected, int a, int b)
        {
            // Act
            int result = _calculator.Subtract(a, b);
            
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Act
            int result = _calculator.Multiply(4, 5);
            
            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            // Act
            double result = _calculator.Divide(10, 2);
            
            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
} 