using System;
using Xunit;
using PrimeLab;

namespace TDD4
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]


        public void One(int a, int expected)
        {
            int result = PrimeNumbers.GetPrime(a);
            Assert.Equal(expected, result);
        }
    }
}
