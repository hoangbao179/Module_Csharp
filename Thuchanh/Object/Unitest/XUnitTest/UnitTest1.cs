using System;
using Xunit;
using Unitest.Calculator;

namespace XUnitTest
{
    public class UnitTest1
    {
        Calculator cal = new Calculator();
        [Fact]
        public void AddFactTest()
        {
            Assert.Equal(10, cal.Add(5, 5));
        }
        [Theory]
        [InlineData(10,10,20)]
        [InlineData(100,100,200)]
        public void AddTheoryTest(int a, int b, int c)
        {
            Assert.Equal(c, cal.Add(a, b));
        }
    }
}
