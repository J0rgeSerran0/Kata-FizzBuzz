using System;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class CalculateTests
    {
        [Fact]
        public void BuzzNumber_ShouldReturn_BuzzResult()
        {
            var result = Calculate.FizzBuzzBy(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FizzNumber_ShouldReturn_FizzResult()
        {
            var result = Calculate.FizzBuzzBy(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void FizzBuzzNumber_ShouldReturn_FizzBuzzResult()
        {
            var result = Calculate.FizzBuzzBy(30);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void NotBuzzOrFizzNumber_ShouldReturn_EmptyResult()
        {
            var result = Calculate.FizzBuzzBy(2);

            Assert.Equal(String.Empty, result);
        }
    }
}